using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;

namespace BashimViewer
{
    class ParserLibrary
    {
        private List<string> quotesList;
        private int indexCurrentQuote;

        public ParserLibrary()
        {
            quotesList = new List<string>();
            indexCurrentQuote = 0;
        }

        public int NumberCurrentQuote
        {
            get { return indexCurrentQuote + 1; }
        }

        public int CoountQuotes
        {
            get { return quotesList.Count; }
        }

        public string GetCurrentQuote()
        {
            return quotesList[indexCurrentQuote];
        }

        public bool MoveNext()
        {
            if (indexCurrentQuote<quotesList.Count-1)
            {
                indexCurrentQuote++;
                return true;
            }

            return false;
        }

        public bool MovePrev()
        {
            if (indexCurrentQuote>0)
            {
                indexCurrentQuote--;
                return true;
            }

            return false;
        }

        public void LoadQuotes()
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string htmlCode = webClient.DownloadString("https://bash.im/best");

            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(htmlCode);

            HtmlNodeCollection nodes = htmlDocument.DocumentNode.SelectNodes("//div[@class='quote__body']");

            foreach (HtmlNode htmlNode in nodes)
            {
                string currentQuote = htmlNode.InnerHtml;
                currentQuote = currentQuote.Trim('\n').Trim(' ').Replace("&quot;", "\"").Replace("<br>", "\n");
                quotesList.Add(currentQuote);
            }
        }

        public Task LoadQuotesAsync()
        {
            return Task.Factory.StartNew(LoadQuotes);
        }
    }
}
