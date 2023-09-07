using DataAccessLayer;
using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Helper
{
    public class ClientHelper
    {
        private static string BaseUrl { get => "http://192.168.1.177/api/"; }
        static HttpClient client = new HttpClient();
        static public TokenAl SetToken
        {
            set
            {
                if (value != null)
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + value.access_token);
            }
        }


        public static string GetToken(string userName, string password)
        {

            string serviceUrl = "http://localhost:62504/token";
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>( "grant_type", "password" ),
                new KeyValuePair<string, string>( "username", userName ),
                new KeyValuePair<string, string> ( "password", password )
            };

            HttpContent content = new FormUrlEncodedContent(pairs);
            HttpResponseMessage response = client.PostAsync(serviceUrl, content).Result;
                    return response.Content.ReadAsStringAsync().Result;

        }

        public static List<T> GetAllEntity<T>(string path)
        {

            List<T> modelKitap = null;

            var response = client.GetAsync(BaseUrl + path).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync();
                modelKitap = JsonConvert.DeserializeObject<List<T>>(responseContent.Result);
            }
            return modelKitap;
        }

        public static T GetEntity<T>(string path)
        {

            var response = client.GetAsync(BaseUrl + path).Result;

            var responseContent = response.Content.ReadAsStringAsync();
            T kitap = JsonConvert.DeserializeObject<T>(responseContent.Result);

            return kitap;
        }
        public static void PostEntity<T>(string path, T entity)
        {
            StringContent httpContent = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            var response = client.PostAsync(BaseUrl + path, httpContent);
        }
        public static void EntityDelete(string path, string id)
        {
            var response = client.DeleteAsync(BaseUrl + path + "/" + id);
        }
        public static void EntityUpdate<T>(string path, string id, T entity)
        {
            StringContent httpContent = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            var response = client.PutAsync(BaseUrl + path + "/" + id, httpContent);
        }

    }
}


