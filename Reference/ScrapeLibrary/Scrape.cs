using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWepPage(string url)
        {
            return GetWebPage(url);
        }

        public string ScrapeWepPage(string url, string filepath)
        {
            string content = GetWebPage(url);
            File.WriteAllText(filepath, content);
            return content;
        }

        private string GetWebPage (string url)
        {
            WebClient client = new WebClient();
            string c  = client.DownloadString(url);
            c += "Koniec strony WWW !!!!!!!!!!!!!!!!!";
            return c;
        }
    }
}
