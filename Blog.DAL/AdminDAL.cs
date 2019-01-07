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
            using (var _connection = ConnectionFactory.GetOpenConnection(ConnStr))
            {
                return _connection.Query<Admin>("select * from Admin").AsList();
            }

        }

        public Admin GetOne(int Id)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(ConnStr))
            {
                return _connection.QueryFirst<Admin>("select * from Admin where Id=@Id and state = 0", new { Id = Id });
            }
        }

        public Admin GetOneByUserName(string UserName)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(ConnStr))
            {
                return _connection.QueryFirst<Admin>("select * from Admin where AName=@AName and state = 0", new { AName = UserName });
            }
        }
        public int UserLogin(string UserName, string PassWord)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(ConnStr))
            {
                return (int)_connection.ExecuteScalar("select count(*) from [Admin] where AName = @AName and APassword = @APassword and [State] = 0 ", new { AName = UserName, APassword = PassWord });
            }
        }
        public bool Add(Admin admin)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(ConnStr))
            {

                if (_connection.Execute("insert into Admin(AName,APassword,Remark) values (@AName, @APassword, @Remark)", admin) > 0)
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
            using (var _connection = ConnectionFactory.GetOpenConnection(ConnStr))
            {

                if (_connection.Execute("update admin set APassword = @APassword,Remark = @Remark where AName = @AName", admin) > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
