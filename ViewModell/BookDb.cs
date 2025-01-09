using Modell;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModell
{
    public class BookDb : BaseDb
    {
        static private BookList list = new BookList();

        public static Book SelectById(int id)
        {
            BookDb db = new BookDb();
            list = db.SelectAll();

            Book g = list.Find(item => item.Id == id);
            return g;
        }
        public BookList SelectAll()
        {
            command.CommandText = $"SELECT * FROM BookTbl";
            BookList perList = new BookList(base.Select());
            return perList;
        }

        protected override Base CreateModel(Base entity)
        {
            Book boo = entity as Book;
            boo.Title = reader["bookName"].ToString();
            boo.Author = reader["author"].ToString();
            boo.ReleaseDate = (DateTime)reader["releaseDate"];
            boo.Pages = int.Parse(reader["pages"].ToString());
            boo.Genres = GenreDb.SelectById(int.Parse(reader["genre"].ToString()));
            boo.Languages = LanguageDb.SelectById(int.Parse(reader["language"].ToString()));
            boo.IsAvailable = (bool)reader["IsAvailable"];
            base.CreateModel(entity);
            return boo;
        }
        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {//הפעולה לא מוחקת את הספר אלא מעדכנת את העמודה להיות שהספר לא יהיה זמין
            Book c = entity as Book;
            if (c != null)
            {
                bool available = false;
                string sqlStr = $"UPDATE  BookTbl SET IsAvailable={available} where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Book b = entity as Book;
            if (b != null)
            {
                string sqlStr = $"INSERT INTO BookTbl (bookName, author, releaseDate, pages, genre, [language], IsAvailable) VALUES (@bName,@au,@rDate,@pag,@genre,@lang,@isAv)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@bName", b.Title));
                command.Parameters.Add(new OleDbParameter("@au", b.Author));
                command.Parameters.Add(new OleDbParameter("@rDate", b.ReleaseDate));
                command.Parameters.Add(new OleDbParameter("@pag", b.Pages));
                command.Parameters.Add(new OleDbParameter("@genre", b.Genres.Id));
                command.Parameters.Add(new OleDbParameter("@lang", b.Languages.Id));
                command.Parameters.Add(new OleDbParameter("@isAv", b.IsAvailable));

            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Book bo = entity as Book;
            if (bo != null)
            {
                string sqlStr = $"Update BookTbl SET bookName=@bName, author=@au, releaseDate=@rDate, pages=@pag, genre=@genre, language=@lan, IsAvailable=@isAv WHERE id=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@bName", bo.Title));
                command.Parameters.Add(new OleDbParameter("@au", bo.Author));
                command.Parameters.Add(new OleDbParameter("@rDate", bo.ReleaseDate));
                command.Parameters.Add(new OleDbParameter("@pag", bo.Pages));
                command.Parameters.Add(new OleDbParameter("@genre", bo.Genres.Id));
                command.Parameters.Add(new OleDbParameter("@lan", bo.Languages.Id));
                command.Parameters.Add(new OleDbParameter("@isAv", bo.IsAvailable));
                command.Parameters.Add(new OleDbParameter("@id", bo.Id));
            }
        }
        protected override Base NewEntity()
        {
            return new Book();
        }
    }
}
