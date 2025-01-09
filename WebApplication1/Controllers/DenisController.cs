using Microsoft.AspNetCore.Mvc;
using Modell;
using ViewModell;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DenisController : ControllerBase
    {
      
        
            [HttpGet("City_Selector")]
            public IActionResult CitySelector()
            {
                CityDb db = new CityDb();
                CityList cities = db.SelectAll();
                return Ok(new { value = cities });
            }
        [HttpGet("someNewCities")]
        public List<string> GetNames()
        {
            List<string> ls = new();
            ls.Add("aaa"); ls.Add("bbb"); ls.Add("ccc");
            return ls;
        }
        [HttpGet("GetInt")]
        public int GetInt()
        {
            
            return 18;
        }
        [HttpGet("GetInts")]
        public List<int> GetInts()
        {
            List<int> ls = new();
            ls.Add(1); ls.Add(2); ls.Add(3);
            return ls;
        }

    }
}
