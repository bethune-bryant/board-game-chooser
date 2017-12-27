using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using HtmlAgilityPack;

namespace BoardGameChooser
{
    static class BGGInterface
    {
        static string BGGURL = @"https://boardgamegeek.com";

        static HtmlWeb web = new HtmlWeb();

        public static List<BoardGame> GetBoardGames(string user)
        {
            HtmlAgilityPack.HtmlDocument doc = web.Load(BGGURL + @"/collection/user/" + user);

            List<BoardGame> result = doc.DocumentNode
                                       .Descendants("tr")
                                       .Where(node => node.Id.StartsWith("row_"))
                                       .Select(node => node.Descendants("a")
                                                           .First(link => link.Attributes["href"].Value.StartsWith("/boardgame"))
                                                           .Attributes["href"].Value)
                                       .Select(suffix => BGGURL + suffix)
                                       .Select(url => GetGameInfo(url))
                                       .ToList();
            return result;
        }

        static string CleanString(string toClean)
        {
            return toClean.Trim().Replace(" ", "").Replace("'", "").Replace('/', '_').Replace('-', '_').Replace("&", "and");
        }

        public static BoardGame GetGameInfo(string url)
        {
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            string gameInfo = doc.DocumentNode
                                 .Descendants("script")
                                 .Select(script => script.InnerText.Trim())
                                 .First(text => text.StartsWith("var GEEK"))
                                 .Split('\n')
                                 .Select(line => line.Trim())
                                 .First(line => line.StartsWith("GEEK.geekitemPreload"));

            gameInfo = gameInfo.Substring(gameInfo.IndexOf('=') + 1).Trim();
            gameInfo = gameInfo.Remove(gameInfo.Length - 1);

            dynamic stuff = JObject.Parse(gameInfo);

            BoardGame retval =  new BoardGame(stuff.item.name.ToString(), 
                                              int.Parse(stuff.item.minplayers.ToString()), 
                                              int.Parse(stuff.item.maxplayers.ToString()), 
                                              int.Parse(stuff.item.minplaytime.ToString()), 
                                              int.Parse(stuff.item.maxplaytime.ToString()));

            foreach(dynamic category in stuff.item.links.boardgamecategory)
            {
                retval.Categories.Add(Enum.Parse(typeof(BoardGame.GameCategory), CleanString(category.name.ToString())));
            }

            foreach (dynamic mechanic in stuff.item.links.boardgamemechanic)
            {
                retval.Mechanisms.Add(Enum.Parse(typeof(BoardGame.GameMechanism), CleanString(mechanic.name.ToString())));
            }

            foreach (dynamic gametype in stuff.item.links.boardgamesubdomain)
            {
                retval.Types.Add(Enum.Parse(typeof(BoardGame.GameType), CleanString(gametype.name.ToString().Replace("Games", "").Replace("games", ""))));
            }

            return retval;
        }
    }
}
