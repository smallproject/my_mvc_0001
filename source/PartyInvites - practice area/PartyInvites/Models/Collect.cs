using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Xml.XPath;

namespace PartyInvites.Models
{
    public class Collect
    {

        public async void Parsing(string urlwebsite)
        {
            try
            {
                HttpClient http = new HttpClient();
                var response = await http.GetByteArrayAsync(urlwebsite);

                String source = Encoding.GetEncoding("utf-8").GetString(response, 0, response.Length - 1);
                source = WebUtility.HtmlDecode(source);

                
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }

}