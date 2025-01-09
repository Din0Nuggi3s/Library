
using System;
using System.Net.Http.Json;

namespace DenisApi
{
    public class JsonResponse
    {
        public int value { get; set; }
    }
    public class Denis_Api : IDenis_Api
    {
        string uri = "http://localhost:5062";
        HttpClient client = new HttpClient();
        public async Task<int> GetCountAsync()
        {
            uri+= "/api/Denis/GetInt/GetInt";
           

            try
            {
                client.GetAsync(uri);
                var result = await client.GetFromJsonAsync<JsonResponse>(uri);
                return (result.value);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return -1;
        }

        // מחלקה שתואמת את המבנה של ה-JSON שמוחזר
       
        

        public Task<List<int>> GetTotalCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetTotalNameAsync()
        {
            throw new NotImplementedException();
        }
    }
}
