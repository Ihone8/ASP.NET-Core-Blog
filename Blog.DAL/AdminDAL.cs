using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;
using Blog.Model;
namespace Blog.DAL
{
    public class AdminDAL
    {
        public string ConnStr { get; set; }

        public AdminDAL(string connstr)
        {
            this.ConnStr = connstr;
        }

        public List<Admin> GetList()
        {
            using (var  _connection = ConnectionFactory.GetOpenConnection(ConnStr) )
            {
                return  _connection.Query<Admin>("select * from Admin").AsList();
            }

        }

        public Admin GetOne(int Id)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(ConnStr))
            {
                return  _connection.QueryFirst<Admin>("select * from Admin where Id=@Id", new { Id = Id });
            }
        }
        public bool Add(Admin admin)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(ConnStr))
            {

                if ( _connection.Execute("insert into Admin(AName,APassword,Remark) values (@AName, @APassword, @Remark)", admin) > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool Delete(int Id)
        {
            return false;
        }

        public bool Update(Admin admin)
        {
            return false;
        }
    }
}
