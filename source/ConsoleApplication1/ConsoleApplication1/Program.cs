using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseClass("jasper.villas@live.com.ph"));
        }

        static void webfunction()
        {
            Uri uri = new Uri("http://www.google.com/");

            Console.WriteLine(uri.AbsolutePath);
            Console.WriteLine(uri.AbsoluteUri);
            Console.WriteLine(uri.Authority);
            Console.WriteLine(uri.DnsSafeHost);
            Console.WriteLine(uri.Fragment);
            Console.WriteLine(uri.Host);
            Console.WriteLine(uri.HostNameType);
            Console.WriteLine(uri.IsAbsoluteUri);
            Console.WriteLine(uri.IsDefaultPort);
            Console.WriteLine(uri.IsFile);
            Console.WriteLine(uri.IsLoopback);
            Console.WriteLine(uri.IsUnc);
            Console.WriteLine(uri.LocalPath);
            Console.WriteLine(uri.OriginalString);
            Console.WriteLine(uri.PathAndQuery);
            Console.WriteLine(uri.Port);
            Console.WriteLine(uri.Query);
            Console.WriteLine(uri.Scheme);
            Console.WriteLine(uri.Segments);
            Console.WriteLine(uri.UserEscaped);
            Console.WriteLine(uri.UserInfo);
        }


        
        static void webfunction1()
        {
            string urlAddress = "http://google.com";

            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();

                Console.WriteLine(data);
            }
        }

        private static bool completed = false;
        private static WebBrowser webBrowserForPrinting = new WebBrowser();
        static void PrintHelpPage()
        {

            webBrowserForPrinting.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(PrintDocument);

            //webBrowserForPrinting.Url = new Uri(@"www.google.com");
            //webBrowserForPrinting.Navigate(@"www.google.com");
            webBrowserForPrinting.Navigate(@"C:\git_root\my_mvc_0001\source\ConsoleApplication1\ConsoleApplication1\Website\HTMLPage1.html");

            while (!completed)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }

            Console.Write("\n\nDone with it!\n\n");
            Console.ReadLine();
        }

        static void PrintDocument(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //((webbrowser)sender).print();

            //((webbrowser)sender).dispose();
            
            //Console.WriteLine(webBrowserForPrinting.Document.Body.InnerHtml);

            //DisplayMetaDescription();
            TestHtml();
            completed = true;
        }

        static void DisplayMetaDescription()
        {
            if (webBrowserForPrinting.Document != null)
            {
                HtmlElementCollection elems = webBrowserForPrinting.Document.GetElementsByTagName("meta");
                foreach (HtmlElement htmlElement in elems)
                {
                    //string nameStr = htmlElement.GetAttribute("name");
                    string nameStr = htmlElement.GetAttribute("charset");
                    
                    Console.WriteLine(htmlElement.All);
                    Console.WriteLine(nameStr);
                    //if (nameStr != null && nameStr.Length != 0)
                    //{
                    //    string contentStr = htmlElement.GetAttribute("content");
                    //    Console.WriteLine("Document: " + webBrowserForPrinting.Url.ToString() + "\nDescription: " + contentStr);
                    //}
                }
            }
        }

        static void TestHtml()
        {
            if (webBrowserForPrinting.Document != null)
            {
                HtmlElementCollection elems = webBrowserForPrinting.Document.GetElementsByTagName("div");
                foreach (HtmlElement htmlElement in elems)
                {
                    Console.WriteLine(htmlElement.InnerText);
                    //foreach (HtmlElement element in htmlElement)
                    //{
                        
                    //}

                    Console.WriteLine("\n\n\n\n");
                    //Console.WriteLine(htmlElement.InnerHtml);

                    //if (htmlElement.GetAttribute("classname").ToString().Equals("g"))
                    //{
                    //    Console.WriteLine(htmlElement.GetAttribute("InnerText"));
                    //}
                }
            }
        }


    }
}
