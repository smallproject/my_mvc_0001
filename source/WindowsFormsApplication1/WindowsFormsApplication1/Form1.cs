using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WebBrowser()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url =
                @"https://www.google.nl/search?es_sm=93&q=site%3A+mercash.nl&oq=site%3A+mercash.nl&gs_l=serp.3...1419.1419.0.1591.1.1.0.0.0.0.68.68.1.1.0....0...1c.1.64.serp..1.0.0.N3nJ0zCsh88";

            List<string> list = new List<string>();

            WebClient webClient = new WebClient();
            string html =
                webClient.DownloadString(url);

            MatchCollection matchCollection = Regex.Matches(html,"<div class=\"g\">\\s*(.+?)\\s*</div>",RegexOptions.Singleline);

            foreach (Match match in matchCollection)
            {
                string content = match.Groups[1].Value;
                list.Add(content);
            }

            webBrowser1.Navigate(url); 
            listBox1.DataSource = list;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var doc = webBrowser1.Document;
            if (doc != null)
            {
                var heads = doc.GetElementsByTagName(@"head");
                if (heads.Count > 0)
                {
                    var scriptEl = doc.CreateElement(@"script");
                    if (scriptEl != null)
                    {
                        //var element = (IHTMLScriptElement)scriptEl.DomElement;

                        //System.Text.StringBuilder sb = new StringBuilder();
                        
                        //element.text = "";
                    }
                }
            }
        }


        private async void Parsing(string urlWebsite)
        {
            try
            {
                HttpClient http = new HttpClient();
                var response = await http.GetByteArrayAsync(urlWebsite);

                String source = Encoding.GetEncoding("utf-8").GetString(response, 0, response.Length - 1);
                source = WebUtility.HtmlDecode(source);
                //HtmlDocument resultat = new HtmlDocument();

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string url =
            //    @"https://www.google.nl/search?es_sm=93&q=site%3A+mercash.nl&oq=site%3A+mercash.nl&gs_l=serp.3...1419.1419.0.1591.1.1.0.0.0.0.68.68.1.1.0....0...1c.1.64.serp..1.0.0.N3nJ0zCsh88";


            //List<string> list = new List<string>();

            //WebClient webClient = new WebClient();
            //string html =
            //    webClient.DownloadString(url);

            //webBrowser1.Navigating += new WebBrowserNavigatingEventHandler(webBrowser1_Navigating);

            string url = @"~View/HTMLPage1.html";


            webBrowser1.Navigate(url);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            System.Windows.Forms.HtmlDocument document = this.webBrowser1.Document;

            Console.WriteLine(document.All["g"]);
        }
    }
}
