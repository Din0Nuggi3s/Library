using Microsoft.AspNetCore.Mvc;
using Modell;
using ViewModell;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControllersProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelecttController : ControllerBase
    {
        [HttpGet("City_Selector")]
        public IActionResult CitySelector()
        {
            CityDb db = new CityDb();
            CityList cities = db.SelectAll();
            return Ok(new { value = cities });
        }






        [HttpGet]
        [ActionName("CitySelector")]
        public CityList SelectAllCities()
        {
            CityDb db = new CityDb();
            CityList cities = db.SelectAll();
            return cities;
        }

        [HttpGet]
        [ActionName("CountrySelector")]
        public CountryList SelectAllCountries()
        {
            CountryDb db = new CountryDb();
            CountryList cuntries = db.SelectAll();
            return cuntries;
        }

        [HttpGet]
        [ActionName("GenreSelector")]
        public GenreList SelectAllGenre()
        {
            GenreDb db = new GenreDb();
            GenreList genre = db.SelectAll();
            return genre;
        }

        [HttpGet]
        [ActionName("LanguageSelector")]
        public LanguageList SelectAllLanguage()
        {
            LanguageDb db = new LanguageDb();
            LanguageList lang = db.SelectAll();
            return lang;
        }

        [HttpGet]
        [ActionName("AdminSelector")]
        public AdminList SelectAllAdmin()
        {
            AdminDb db = new AdminDb();
            AdminList ad = db.SelectAll();
            return ad;
        }

        [HttpGet]
        [ActionName("BookSelector")]
        public BookList SelectAllBook()
        {
            BookDb db = new BookDb();
            BookList book = db.SelectAll();
            return book;
        }

        [HttpGet]
        [ActionName("BorrowSelector")]
        public BorrowList SelectAllBorrow()
        {
            BorrowDb db = new BorrowDb();
            BorrowList book = db.SelectAll();
            return book;
        }

    }
}
