using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using Blog.Model;
namespace Blog.DAL
{
    public class CategoryDAL
    {


        public string ConnStr { get; set; }

        public CategoryDAL(string connstr)
        {
            this.ConnStr = connstr;
        }



        private readonly IDbConnection _connection;
        public IEnumerable<CATEGORY> GetList()
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                return _connection.Query<CATEGORY>("select * from CATEGORY where state = 0");
            }
        }

        public CATEGORY GetOne(int Id)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                return _connection.QueryFirst<CATEGORY>("select * from CATEGORY where Id=@Id and State = 0", new { Id = Id });
            }
        }
        public bool Add(CATEGORY entity)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                if (_connection.Execute("insert into Category(CName,CId,Remark) values (@CName, @CId, @Remark)", entity) > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public bool Delete(int Id, bool IsDelete = false)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                if (IsDelete)
                {
                    if (_connection.Execute("DELETE FROM [Category] where Id=@Id", new { Id = Id }) > 0)
                    {
                        return true;
                    }
                }
                else
                {
                    if (_connection.Execute("update   [Category] set State = 1  where Id=@Id", new { Id = Id }) > 0)
                    {
                        return true;
                    }

                }
                return false;
            }
        }

        public bool Update(CATEGORY category)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                if (_connection.Execute("UPDATE [Category] SET [CName] = @CName,[Remark] = @Remark WHERE Id =@Id ", category) > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public int GetCount()
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.ConnStr))
            {
                return (int)_connection.ExecuteScalar("select count(*) from Category where State = 0");
            }
        }
    }
}
