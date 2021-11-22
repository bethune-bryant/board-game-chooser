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
using System.Net;
using System.Xml.Linq;

namespace BoardGameChooser
{
    static class BGGInterface
    {
        static string BGGURL = @"https://www.boardgamegeek.com/xmlapi2/";

        private static readonly HttpClient client = new HttpClient();
        private static bool initialized = false;
        static int timeout = 100;

        public static List<BoardGame> GetBoardGames(string user)
        {
            if (!initialized)
            {
                client.BaseAddress = new Uri(BGGURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                client.DefaultRequestHeaders.Add("User-Agent", "BoardGameChooser");
                initialized = true;
            }

            byte[] response = client.GetByteArrayAsync("collection?username=" + user).Result;
            string xmlResponse = System.Text.Encoding.UTF8.GetString(response);
            XDocument doc = XDocument.Parse(xmlResponse);
            List<BoardGame> results = doc.Element("items")
                                         .Descendants("item")
                                         .Where(node => node.Attribute("subtype").Value == "boardgame")
                                         .Select(node => GetGameInfo(node.Attribute("objectid").Value))
                                         .ToList();
            return results;
        }

        static string CleanString(string toClean)
        {
            return toClean.Trim().Replace(" ", "").Replace("'", "").Replace('/', '_').Replace('-', '_').Replace("&", "and");
        }
        
        public static BoardGame GetGameInfo(string id)
        {
            string xmlResponse = "";
            while (xmlResponse.Length == 0)
            {
                try
                {
                    System.Threading.Thread.Sleep(timeout);
                    byte[] response = client.GetByteArrayAsync("thing?id=" + id).Result;
                    xmlResponse = Encoding.UTF8.GetString(response);
                }
                catch (Exception exc)
                {
                    if(!exc.ToString().Contains("429"))
                    {
                        throw exc;
                    }
                    else
                    {
                        timeout += 100;
                    }
                }
            }
            XDocument doc = XDocument.Parse(xmlResponse);

            string name = doc.Element("items")
                             .Element("item")
                             .Descendants("name")
                             .Where(node => node.Attribute("type").Value == "primary")
                             .First()
                             .Attribute("value").Value;
            int minPlayers = int.Parse(doc.Element("items")
                                          .Element("item")
                                          .Descendants("minplayers")
                                          .First()
                                          .Attribute("value").Value);
            int maxPlayers = int.Parse(doc.Element("items")
                                          .Element("item")
                                          .Descendants("maxplayers")
                                          .First()
                                          .Attribute("value").Value);
            int minPlayTime = int.Parse(doc.Element("items")
                                          .Element("item")
                                          .Descendants("minplaytime")
                                          .First()
                                          .Attribute("value").Value);
            int maxPlayTime = int.Parse(doc.Element("items")
                                          .Element("item")
                                          .Descendants("maxplaytime")
                                          .First()
                                          .Attribute("value").Value);
            int minAge = int.Parse(doc.Element("items")
                                          .Element("item")
                                          .Descendants("minage")
                                          .First()
                                          .Attribute("value").Value);
            List<string> categories = doc.Element("items")
                                    .Element("item")
                                    .Descendants("link")
                                    .Where(node => node.Attribute("type").Value == "boardgamecategory")
                                    .Select(node => node.Attribute("value").Value)
                                    .ToList();
            List<string> mechanics = doc.Element("items")
                                    .Element("item")
                                    .Descendants("link")
                                    .Where(node => node.Attribute("type").Value == "boardgamemechanic")
                                    .Select(node => node.Attribute("value").Value)
                                    .ToList();

            BoardGame retval = new BoardGame(name, minPlayers, maxPlayers, minPlayTime, maxPlayTime, minAge, new List<string>(), categories, mechanics);

            return retval;
            /*
            foreach (dynamic gametype in stuff.item.links.boardgamesubdomain)
            {
                retval.Types.Add(Enum.Parse(typeof(BoardGame.GameType), CleanString(gametype.name.ToString().Replace("Games", "").Replace("games", ""))));
            }
            */
        }
        
    }
}
