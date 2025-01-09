using Modell;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModell
{
    public class SubDb : PersonDb
    {
        static private SubList list = new SubList();

        public static Sub SelectById(int id)
        {
            SubDb db = new SubDb();
            list = db.SelectAll();

            Sub g = list.Find(item => item.Id == id);
            return g;
        }
        public SubList SelectAll()
        {
            command.CommandText = $"SELECT PersonTbl.*, SubTbl.UserName, SubTbl.[password], SubTbl.phoneNum, SubTbl.Email FROM (PersonTbl INNER JOIN SubTbl ON PersonTbl.id = SubTbl.id)";
            SubList perList = new SubList(base.Select());
            return perList;
        }

        protected override Base CreateModel(Base entity)
        {
            Sub boo = entity as Sub;
            boo.UserName = reader["UserName"].ToString();
            boo.Password = reader["password"].ToString();
            boo.PhoneNum = int.Parse(reader["phoneNum"].ToString());
            boo.Email = reader["Email"].ToString();
            base.CreateModel(entity);
            return boo;
        }
        protected override Base NewEntity()
        {
            return new Sub();
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
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Sub p = entity as Sub;
            if (p != null)
            {
                string sqlStr = $"INSERT INTO SubTbl (id, UserName, [password], phoneNum,Email) VALUES (@id,@uName,@pw,@pNum,@eM)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
                command.Parameters.Add(new OleDbParameter("@uName", p.UserName));
                command.Parameters.Add(new OleDbParameter("@pw", p.Password));
                command.Parameters.Add(new OleDbParameter("@pNum", p.PhoneNum));
                command.Parameters.Add(new OleDbParameter("@eM", p.Email));
            }
        }
        public override void Insert(Base entity)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertSQL, entity));
            }
        }
        public void Insert(Base entity, bool FromAdmin)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertSQL, entity));
                if (!FromAdmin)
                    inserted.Add(new ChangeEntity(this.CreateInsertSQL, entity));
            }
        }

        public override void Update(Base entity)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                updated.Add(new ChangeEntity(base.CreateUpdateSQL, entity));
                updated.Add(new ChangeEntity(this.CreateUpdateSQL, entity));
            }
        }
        public void Update(Base entity, bool FromAdmin)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                updated.Add(new ChangeEntity(base.CreateUpdateSQL, entity));
                if (!FromAdmin)
                    updated.Add(new ChangeEntity(this.CreateUpdateSQL, entity));
            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Sub p = entity as Sub;
            if (p != null)
            {
                string sqlStr = $"Update SubTbl SET UserName=@Un, [password]=@pass, phoneNum=@Pn, Email=@em WHERE id=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@Un", p.UserName));
                command.Parameters.Add(new OleDbParameter("@pass", p.Password));
                command.Parameters.Add(new OleDbParameter("@Pn", p.PhoneNum));
                command.Parameters.Add(new OleDbParameter("@em", p.Email));
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}
