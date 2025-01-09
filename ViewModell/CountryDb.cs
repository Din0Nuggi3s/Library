using Modell;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModell
{
    public class CountryDb : BaseDb
    {
        static private CountryList list = new CountryList();

        public static Country SelectById(int id)
        {
            CountryDb db = new CountryDb();
            list = db.SelectAll();

            Country g = list.Find(item => item.Id == id);
            return g;
        }
        protected override Base CreateModel(Base entity)
        {
            Country c = entity as Country;
            c.CountryName = reader["counries"].ToString();
            return base.CreateModel(entity);
        }
        public CountryList SelectAll()
        {
            command.CommandText = $"SELECT * FROM CountriesTbl";
            CountryList coList = new CountryList(base.Select());
            return coList;
        }

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Country c = entity as Country;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM CountriesTbl where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Country b = entity as Country;
            if (b != null)
            {
                string sqlStr = $"Insert into CountriesTbl (countries) values (@bName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@bName", b.CountryName));
            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Country c = entity as Country;
            if (c != null)
            {
                string sqlStr = $"Update CountriesTbl SET countries=@cName WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.CountryName));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
        protected override Base NewEntity()
        {
            return new Country();
        }
    }
}
