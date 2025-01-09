using Modell;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModell
{
    public class GenreDb : BaseDb
    {
        static private GenreList list = new GenreList();

        public static Genre SelectById(int id)
        {
            GenreDb db = new GenreDb();
            list = db.SelectAll();

            Genre g = list.Find(item => item.Id == id);
            return g;
        }
        protected override Base CreateModel(Base entity)
        {
            Genre g = entity as Genre;
            g.GenreName = reader["genres"].ToString();
            return base.CreateModel(entity);
        }
        public GenreList SelectAll()
        {
            command.CommandText = $"SELECT * FROM GenresTbl";
            GenreList gList = new GenreList(base.Select());
            return gList;
        }
        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Genre c = entity as Genre;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM GenresTbl where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Genre b = entity as Genre;
            if (b != null)
            {
                string sqlStr = $"Insert into GenresTbl (genres) values (@bName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@bName", b.GenreName));
            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Genre c = entity as Genre;
            if (c != null)
            {
                string sqlStr = $"Update GenreTbl SET genres=@cName WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.GenreName));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
        protected override Base NewEntity()
        {
            return new Genre();
        }
    }
}
