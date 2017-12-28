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

namespace BoardGameChooser
{
    public static class RandOrgInterface
    {
        static HtmlWeb web = new HtmlWeb();

        public static int RandInt(int min, int max)
        {
            try
            {
                string url = @"https://www.random.org/integers/?num=1&min=" + min.ToString() + @"&max=" + (max - 1).ToString() + @"&col=1&base=10&format=plain&rnd=new";

                string result = string.Empty;

                HttpWebRequest req = WebRequest.CreateHttp(url);
                req.Timeout = 3000;
                req.Accept = "text/html";
                req.UserAgent = @"Mozilla/5.0 (Windows NT 6.2; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1667.0 Safari/537.36";
                WebResponse res = req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                result = reader.ReadToEnd();
                reader.Close();
                res.Close();

                return int.Parse(result.Trim());
            }
            catch
            {
                return Form1.settings.rand.Next(min, max);
            }
        }

    }
}
