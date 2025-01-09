using Modell;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModell
{
    public class AdminDb : SubDb
    {
        static private AdminList list = new AdminList();

        public static Admin SelectById(int id)
        {
            AdminDb db = new AdminDb();
            list = db.SelectAll();

            Admin g = list.Find(item => item.Id == id);
            return g;
        }
        public AdminList SelectAll()
        {
            command.CommandText = $"SELECT PersonTbl.*, SubTbl.UserName, SubTbl.[password], SubTbl.phoneNum, SubTbl.Email FROM ((AdminTbl INNER JOIN PersonTbl ON AdminTbl.id = PersonTbl.id) INNER JOIN SubTbl ON AdminTbl.id = SubTbl.id AND PersonTbl.id = SubTbl.id)";
            AdminList perList = new AdminList(base.Select());
            return perList;
        }

        protected override Base CreateModel(Base entity)
        {
            Admin boo = entity as Admin;
            base.CreateModel(entity);
            return boo;
        }
        public override void Delete(Base entity)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
            }
        }
        public override void Insert(Base entity)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                base.Insert(entity, true);
                inserted.Add(new ChangeEntity(base.CreateInsertSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertSQL, entity));
            }
        }


        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Admin bo = entity as Admin;
            if (bo != null)
            {
                string sqlStr = $"Insert into AdminTbl (id) values (@id)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", bo.Id));
            }
        }
        public override void Update(Base entity)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                base.Update(entity, true);
                updated.Add(new ChangeEntity(base.CreateUpdateSQL, entity));
                updated.Add(new ChangeEntity(this.CreateUpdateSQL, entity));
            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Admin p = entity as Admin;
            if (p != null)
            {
                string sqlStr = $"Update AdminTbl SET id=@id WHERE id=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
        protected override Base NewEntity()
        {
            return new Admin();
        }
    }
}
