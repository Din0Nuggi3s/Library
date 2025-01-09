using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    //public static async Task DoIt()
    //{
    //    LibInterface api = new LibInterface();
    //    //   Apiservice api = new Apiservice();
    //    CityList cList = new CityList();
    //    try { cList = await api.GetAllCities(); }
    //    catch (Exception ex)
    //    {
    //        Debug.WriteLine(ex.Message);
    //        Console.WriteLine(ex.Message);
    //    }

    //    Console.WriteLine(cList[0]);
    //}
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("bbbbbbbbbbbbbbbbbbbbbbbbb");
    //    Console.ForegroundColor = ConsoleColor.Green;
    //    DoIt();














    //CITY INSERT
    //#region
    //City cy = new City(){CityName="Nesher"};
    //CityDb cDb = new CityDb();
    //CityList cities = cDb.SelectAll();
    //foreach (City c in cities)
    //    Console.WriteLine(c.CityName);
    //cDb.Insert(cy);
    //cDb.SaveChanges();
    //CityList cities1 = cDb.SelectAll();
    //foreach (City c in cities1)
    //    Console.WriteLine(c.CityName);
    //#endregion


    //CITY DELETE
    //    #region
    //    CityDb cDB = new CityDb();
    //CityList cities = cDB.SelectAll();
    //    foreach (City c in cities)
    //        Console.WriteLine(c.CityName);
    //    City cLast = cities.Last();
    //cDB.Delete(cLast);
    //    cDB.SaveChanges();
    //    Console.WriteLine("delete :");
    //    cities = cDB.SelectAll();
    //    foreach (City c in cities)
    //        Console.WriteLine(c.CityName);
    //    #endregion


        //CITY UPDATE
        //#region
        //CityDb CDB = new CityDb();
        //CityList cities = CDB.SelectAll();
        //foreach (City city in cities)
        //    Console.WriteLine(city.CityName);
        //City city1 = cities[0];
        //city1.CityName = "Rome";
        //CDB.Update(city1);
        //CDB.SaveChanges();
        //Console.WriteLine("after : ");
        //foreach (City city in cities)
        //    Console.WriteLine(city.CityName);
        //#endregion


        //BORROW UPDATE
        //#region
        //City cilast = new City();
        //cilast.CityName = "London";
        //Country colast = new Country();
        //colast.CountryName = "England";
        //Borrow clast = new Borrow();
        //BorrowDb CDB = new BorrowDb();
        //BorrowList cities = CDB.SelectAll();
        //foreach (Borrow city in cities)
        //{
        //    Console.WriteLine(city.PersonSub.ToString() + " ");
        //    Console.WriteLine(city.BookName.ToString() + " " + city.BorrowDate + " " + city.ReturnDate + " ");
        //}
        //Borrow city1 = cities[0];
        //city1.BorrowDate = new DateTime(2023, 2, 3);
        //city1.ReturnDate = new DateTime(2025, 3, 2);
        //CDB.Update(city1);
        //CDB.SaveChanges();
        //cities = CDB.SelectAll();
        //Console.WriteLine("after : ");
        //foreach (Borrow city in cities)
        //{
        //    Console.WriteLine(city.PersonSub.ToString() + " ");
        //    Console.WriteLine(city.BookName.ToString() + " " + city.BorrowDate + " " + city.ReturnDate + " ");
        //}
        //#endregion


        //PERSON INSERT
        //#region
        //CityDb ci = new CityDb();
        //CityList clast = ci.SelectAll();
        //CountryDb co = new CountryDb();
        //CountryList colast = co.SelectAll();
        //PersonDb CDB = new PersonDb();
        //PersonList cities = CDB.SelectAll();
        //foreach (Person city in cities)
        //    Console.WriteLine(city.FName + " " + city.LName + " " + city.Birthdate + " " + city.Cities + " " + city.Countries + " ");
        //Person city1 = new Person()
        //{
        //    FName = "Frank",
        //    LName = "Badminton",
        //    Birthdate = new DateTime(2007, 2, 3),
        //    Cities = clast[2],
        //    Countries = colast[2]
        //};
        //CDB.Insert(city1);
        //CDB.SaveChanges();
        //cities = CDB.SelectAll();
        //Console.WriteLine("after : ");
        //foreach (Person city in cities)
        //    Console.WriteLine(city.FName + " " + city.LName + " " + city.Birthdate + " " + city.Cities.CityName + " " + city.Countries.CountryName + " ");
        //#endregion


        //BORROW INSERT
        //#region
        //SubDb perd = new SubDb();
        //SubList plst = perd.SelectAll();
        //BookDb bo = new BookDb();
        //BookList boo = bo.SelectAll();
        //Borrow clast = new Borrow();
        //BorrowDb CDB = new BorrowDb();
        //BorrowList cities = CDB.SelectAll();
        //foreach (Borrow city in cities)
        //{
        //    Console.WriteLine(city.PersonSub.ToString() + " ");
        //    Console.WriteLine(city.BookName.ToString() + " " + city.BorrowDate + " " + city.ReturnDate + " ");
        //}
        //Borrow citty1 = new Borrow()
        //{
        //    PersonSub = plst[0],
        //    BookName = boo[1],
        //    BorrowDate = new DateTime(2024,3,12),
        //    ReturnDate = new DateTime(2026,12,30)
        //};
        //CDB.Insert(citty1);
        //CDB.SaveChanges();
        //cities = CDB.SelectAll();
        //Console.WriteLine("after : ");
        //foreach (Borrow city in cities)
        //{
        //    Console.WriteLine(city.PersonSub.UserName + " ");
        //    Console.WriteLine(city.BookName.Title + " " + city.BorrowDate + " " + city.ReturnDate + " ");
        //}
        //#endregion



        //BOOK INSERT
        //#region
        //GenreDb ci = new GenreDb();
        //GenreList clast = ci.SelectAll();
        //LanguageDb co = new LanguageDb();
        //LanguageList colast = co.SelectAll();
        //BookDb CDB = new BookDb();
        //BookList cities = CDB.SelectAll();
        //foreach (Book city in cities)
        //    Console.WriteLine(city.Title + " " + city.Author + " " + city.Pages + " " + city.Genres + " " + city.Languages + " ");
        //Book city1 = new Book()
        //{
        //    Title = "Being Furry is fun!",
        //    Author = "Shon gorinshtein",
        //    ReleaseDate = new DateTime (2024,3,3),
        //    Pages = 69,
        //    Genres = clast[0],
        //    Languages = colast[0],
        //    IsAvailable = true
        //};
        //CDB.Insert(city1);
        //CDB.SaveChanges();
        //cities = CDB.SelectAll();
        //Console.WriteLine("after : ");
        //foreach (Book city in cities)
        //    Console.WriteLine(city.Title + " " + city.Author + " " + city.Pages + " " + city.Genres.GenreName + " " + city.Languages.LanguageName + " ");
        //#endregion



        //ADMIN UPDATE
        //#region
        //AdminDb CDB = new AdminDb();
        //AdminList cities = CDB.SelectAll();
        //foreach (Admin city in cities)
        //    Console.WriteLine(city.ToString().ToString().ToString());
        //Admin city1 = cities[0];
        //city1.UserName = "Bilbal";
        //CDB.Update(city1);
        //CDB.SaveChanges();
        //cities = CDB.SelectAll();
        //Console.WriteLine("after : ");
        //foreach (Admin city in cities)
        //    Console.WriteLine(city.ToString().ToString().ToString());
        //#endregion



        //ADMIN INSERT
        //#region
        //AdminDb CDB = new AdminDb();
        //AdminList cities = CDB.SelectAll();
        //foreach (Admin city in cities)
        //    Console.WriteLine(city.ToString().ToString().ToString());


        //SubDb pDB = new SubDb();
        //SubList people = pDB.SelectAll();
        //Sub person = people.Last();
        //Admin admin = new Admin
        //{
        //    FName = person.FName,
        //    LName = person.LName,
        //    Birthdate = person.Birthdate,
        //    Cities = person.Cities,
        //    Countries = person.Countries,
        //    UserName = person.UserName,
        //    Password = person.Password,
        //    PhoneNum = person.PhoneNum,
        //    Email = person.Email
        //};
        //CDB.Insert(admin);
        //CDB.SaveChanges();
        //cities = CDB.SelectAll();
        //Console.WriteLine("after : ");
        //foreach (Admin city in cities)
        //    Console.WriteLine(city.ToString().ToString().ToString());
        //#endregion



        //SUB INSERT
        //#region
        //CityDb ci = new CityDb();
        //CityList clast = ci.SelectAll();
        //CountryDb co = new CountryDb();
        //CountryList colast = co.SelectAll();
        //SubDb CDB = new SubDb();
        //SubList cities = CDB.SelectAll();
        //foreach (Sub city in cities)
        //    Console.WriteLine(city.ToString().ToString().ToString());


        //PersonDb pDB = new PersonDb();
        //PersonList people = pDB.SelectAll();
        //Person person = people.Last();
        //Sub admin = new Sub
        //{
        //    FName = person.FName,
        //    LName = person.LName,
        //    Birthdate = person.Birthdate,
        //    Cities = person.Cities,
        //    Countries = person.Countries,
        //    UserName = "Tmuna",
        //    Password = "mawawawaw",
        //    PhoneNum = 500,
        //    Email = "504",
        //};

        //CDB.Insert(admin);
        //CDB.SaveChanges();
        //cities = CDB.SelectAll();
        //Console.WriteLine("after : ");
        //foreach (Sub city in cities)
        //    Console.WriteLine(city.ToString().ToString().ToString() + " " + city.FName + city.LName);
        //#endregion


        //BOOK DELETE
        //#region
        //BookDb cDB = new BookDb();
        //BookList cities = cDB.SelectAll();
        //foreach (Book c in cities)
        //    Console.WriteLine(c);
        //Book city1 = cities[0];
        //cDB.Delete(city1);
        //cDB.SaveChanges();
        //cities = cDB.SelectAll();
        //Console.WriteLine("after : ");
        //foreach (Book city in cities)
        //    Console.WriteLine(city);
        //#endregion


        //SUB UPDATE
        //#region
        //SubDb CDB = new SubDb();
        //SubList cities = CDB.SelectAll();
        //foreach (Sub city in cities)
        //    Console.WriteLine(city.ToString().ToString().ToString());


        //Sub admin = cities[0];
        //admin.UserName = "mehehehehehehehehehe";

        //CDB.Update(admin);
        //CDB.SaveChanges();
        //cities = CDB.SelectAll();
        //Console.WriteLine("after : ");
        //foreach (Sub city in cities)
        //    Console.WriteLine(city.ToString().ToString().ToString());
        //#endregion


        //ADMIN UPDATE
        //#region
        //AdminDb CDB = new AdminDb();
        //AdminList cities = CDB.SelectAll();
        //foreach (Admin city in cities)
        //    Console.WriteLine(city.ToString().ToString().ToString());


        //SubDb pDB = new SubDb();
        //SubList people = pDB.SelectAll();
        //Sub person = people.Last();
        //Admin admin = cities[0];
        //admin.FName = person.FName;
        //admin.LName = person.LName;
        //admin.Birthdate = person.Birthdate;
        //admin.Cities = person.Cities;
        //admin.Countries = person.Countries;
        //admin.UserName = person.UserName;
        //admin.Password = person.Password;
        //admin.PhoneNum = person.PhoneNum;
        //admin.Email = person.Email;

        //CDB.Update(admin);
        //CDB.SaveChanges();
        //cities = CDB.SelectAll();
        //Console.WriteLine("after : ");
        //foreach (Admin city in cities)
        //    Console.WriteLine(city.ToString().ToString().ToString());
        //#endregion
    }

