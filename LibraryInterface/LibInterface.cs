using Modell;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LibraryInterface
{
    public class LibInterface : ILibraryInterface
    {//http://localhost:5062/api/Denis/CitySelector/City_Selector
        string uri;
        HttpClient client;

        public LibInterface()
        {
            uri = "";
            client = new HttpClient();
        }
        public LibInterface(HttpClient client, string baseUri)
        {
            uri = "http://localhost:5298/api/Selectt/";
            client = new HttpClient();
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.uri = baseUri ?? throw new ArgumentNullException(nameof(baseUri));
        }

       

        public async Task<CityList> GetAllCities()
        {
            string x = uri + "City_Selector";
            return await client.GetFromJsonAsync<CityList>(uri + "CitySelector");
          
        }
        public async Task<BookList> GetAllBooks()
        {
            string x = uri + "BookSelector";
            return await client.GetFromJsonAsync<BookList>(uri + "BookSelector");
          
        }

       
        
    }
}
