using Modell;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModell
{
    public class BorrowDb : BaseDb
    {
        static private BorrowList list = new BorrowList();

        public static Borrow SelectById(int id)
        {
            BorrowDb db = new BorrowDb();
            list = db.SelectAll();

            Borrow g = list.Find(item => item.Id == id);
            return g;
        }
        public BorrowList SelectAll()
        {
            command.CommandText = $"SELECT * FROM BorrowTbl";
            BorrowList perList = new BorrowList(base.Select());
            return perList;
        }

        protected override Base CreateModel(Base entity)
        {
            Borrow bor = entity as Borrow;
            bor.BorrowDate = (DateTime)reader["borrowDate"];
            bor.ReturnDate = (DateTime)reader["returnDate"];
            bor.PersonSub = SubDb.SelectById(int.Parse(reader["personSub"].ToString()));
            bor.BookName = BookDb.SelectById(int.Parse(reader["book"].ToString()));
            base.CreateModel(entity);
            return bor;
        }
        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Borrow c = entity as Borrow;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM BorrowTbl where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Borrow bo = entity as Borrow;
            if (bo != null)
            {
                string sqlStr = $"Insert into BorrowTbl (personSub, book, borrowDate, returnDate) values (@pSub, @b, @bDate, @rDate)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pSub", bo.PersonSub.Id));
                command.Parameters.Add(new OleDbParameter("@b", bo.BookName.Id));
                command.Parameters.Add(new OleDbParameter("@bDate", bo.BorrowDate));
                command.Parameters.Add(new OleDbParameter("@rDate", bo.ReturnDate));

            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Borrow bo = entity as Borrow;
            if (bo != null)
            {
                string sqlStr = $"Update BorrowTbl SET personSub=@pSub, book=@b, borrowDate=@bDate, returnDate=@rDate WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pSub", bo.PersonSub.Id));
                command.Parameters.Add(new OleDbParameter("@b", bo.BookName.Id));
                command.Parameters.Add(new OleDbParameter("@bDate", bo.BorrowDate));
                command.Parameters.Add(new OleDbParameter("@rDate", bo.ReturnDate));
                command.Parameters.Add(new OleDbParameter("@id", bo.Id));
            }
        }
        protected override Base NewEntity()
        {
            return new Borrow();
        }
    }
}
