using Newtonsoft.Json;
using Owin_C2009L_NguyenVanA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Owin_C2009L_NguyenVanA
{
    public class ApiClient
    {
        //call api
        private static string SERVER_NAME = "localhost";
        private static string PORT = "9000";
        public static string baseAddress = $"http://{SERVER_NAME}:{PORT}/";
        private HttpClient client = new HttpClient();
        
        string urlGetAlbum = $"{baseAddress}api/Album/2";
        string urlInsertAlbum = $"{baseAddress}api/Album";

        public HttpResponseMessage GetAllAlbums() {
            string urlGetAllAlbum = $"{baseAddress}api/Album";
            HttpResponseMessage response = client.GetAsync(urlGetAllAlbum).Result;            
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            return response;
        }
        public HttpResponseMessage GetAlbumById(int id)
        {
            string urlGetAllAlbum = $"{baseAddress}api/Album/{id}";
            HttpResponseMessage response = client.GetAsync(urlGetAllAlbum).Result;
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            return response;
        }
        public void InsertAlbum(Album album)
        {
            var serializedObject = JsonConvert.SerializeObject(album);            
            var byteContent = new ByteArrayContent(Encoding.UTF8.GetBytes(serializedObject));

            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client
                .PostAsync($"{baseAddress}api/Album", byteContent)
                .Result;
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);            
        }
        public void UpdateAlbum(Album album)
        {
            var serializedObject = JsonConvert.SerializeObject(album);
            var byteContent = new ByteArrayContent(Encoding.UTF8.GetBytes(serializedObject));            
            HttpResponseMessage response = client
                .PutAsync($"{baseAddress}api/Album", byteContent)
                .Result;
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        }
        public HttpResponseMessage DeleteAlbumById(int id)
        {
            string urlGetAllAlbum = $"{baseAddress}api/Album/{id}";
            HttpResponseMessage response = client.DeleteAsync(urlGetAllAlbum).Result;
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            return response;
        }
    }
}
