using Modell;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModell
{
    public class CityDb : BaseDb
    {
        static private CityList list = new CityList();

        public static City SelectById(int id)
        {
            CityDb db = new CityDb();
            list = db.SelectAll();

            City g = list.Find(item => item.Id == id);
            return g;
        }
        protected override Base CreateModel(Base entity)
        {
            City c = entity as City;
            c.CityName = reader["cities"].ToString();
            return base.CreateModel(entity);
        }
        public CityList SelectAll()
        {
            command.CommandText = $"SELECT * FROM CitiesTbl";
            CityList ciList = new CityList(base.Select());
            return ciList;
        }
        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            City c = entity as City;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM CitiesTbl where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            City c = entity as City;
            if (c != null)
            {
                string sqlStr = $"Insert into CitiesTbl (cities) values (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.CityName));
            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            City c = entity as City;
            if (c != null)
            {
                string sqlStr = $"Update CitiesTbl SET cities=@cName WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.CityName));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));

            }
        }
        protected override Base NewEntity()
        {
            return new City();
        }
    }
}
