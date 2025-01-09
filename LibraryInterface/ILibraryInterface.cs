using Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInterface
{
    public interface ILibraryInterface
    {
        //public Task<CityList> GetAllCities();
        public Task<CityList> GetAllCities();
    }
}
