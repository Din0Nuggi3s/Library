using Modell;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModell
{
    public class LanguageDb : BaseDb
    {
        static private LanguageList list = new LanguageList();

        public static Language SelectById(int id)
        {
            LanguageDb db = new LanguageDb();
            list = db.SelectAll();

            Language g = list.Find(item => item.Id == id);
            return g;
        }
        protected override Base CreateModel(Base entity)
        {
            Language l = entity as Language;
            l.LanguageName = reader["languages"].ToString();
            return base.CreateModel(entity);
        }
        public LanguageList SelectAll()
        {
            command.CommandText = $"SELECT * FROM LanguageTbl";
            LanguageList lList = new LanguageList(base.Select());
            return lList;
        }
        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Language c = entity as Language;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM LanguageTbl where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Language b = entity as Language;
            if (b != null)
            {
                string sqlStr = $"INSERT INTO LanguageTbl (languages) VALUES (@lName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@lName", b.LanguageName));
            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Language c = entity as Language;
            if (c != null)
            {
                string sqlStr = $"Update LanguageTbl SET languages=@cName WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.LanguageName));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
        protected override Base NewEntity()
        {
            return new Language();
        }
    }
}
