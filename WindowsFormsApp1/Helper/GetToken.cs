using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Helper
{
   public  class GetToken
    {
        static HttpClient client = new HttpClient();
        public static async Task<string> Token(string userName, string password)
        {
            string serviceUrl = "http://localhost:62504/token";
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>( "grant_type", "password" ),
                new KeyValuePair<string, string>( "username", userName ),
                new KeyValuePair<string, string> ( "Password", password )
            };
            HttpContent content = new FormUrlEncodedContent(pairs);
            using (HttpResponseMessage response = await client.PostAsync(serviceUrl, content))
                return await response.Content.ReadAsStringAsync();
        }
    }
}
