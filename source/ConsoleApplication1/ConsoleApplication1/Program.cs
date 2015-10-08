using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            webfunction1();
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
    }
}
