using Modell;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModell
{
    public class PersonDb : BaseDb
    {
        static private PersonList list = new PersonList();

        public static Person SelectById(int id)
        {
            PersonDb db = new PersonDb();
            list = db.SelectAll();

            Person g = list.Find(item => item.Id == id);
            return g;
        }
        public PersonList SelectAll()
        {
            command.CommandText = $"SELECT * FROM PersonTbl";
            PersonList perList = new PersonList(base.Select());
            return perList;
        }

        protected override Base CreateModel(Base entity)
        {
            Person per = entity as Person;
            per.FName = reader["fName"].ToString();
            per.LName = reader["lName"].ToString();
            per.Birthdate = (DateTime)reader["birthDate"];
            per.Cities = CityDb.SelectById(int.Parse(reader["City"].ToString()));
            per.Countries = CountryDb.SelectById(int.Parse(reader["Country"].ToString()));
            base.CreateModel(entity);
            return per;
        }
        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Person c = entity as Person;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM PersonTbl where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Person p = entity as Person;
            if (p != null)
            {
                string sqlStr = $"Insert INTO PersonTbl (fName, lName, birthDate, City, Country) values (@fName,@lName,@bDate,@ci,@co)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@fName", p.FName));
                command.Parameters.Add(new OleDbParameter("@lName", p.LName));
                command.Parameters.Add(new OleDbParameter("@bDate", p.Birthdate));
                command.Parameters.Add(new OleDbParameter("@ci", p.Cities.Id));
                command.Parameters.Add(new OleDbParameter("@co", p.Countries.Id));
            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Person p = entity as Person;
            if (p != null)
            {
                string sqlStr = $"Update PersonTbl SET fName=@fName, lName=@lName, birthDate=@bDate, City=@ci, Country=@co WHERE id=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@fName", p.FName));
                command.Parameters.Add(new OleDbParameter("@lName", p.LName));
                command.Parameters.Add(new OleDbParameter("@bDate", p.Birthdate));
                command.Parameters.Add(new OleDbParameter("@ci", p.Cities.Id));
                command.Parameters.Add(new OleDbParameter("@co", p.Countries.Id));
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
        protected override Base NewEntity()
        {
            return new Person();
        }
    }
}
