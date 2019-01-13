using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Linq;
using Blog.Model;
namespace Blog.DAL
{
    public class UserDAL
    {
        public string connStr { get; set; }

        public UserDAL(string connstr)
        {
            this.connStr = connStr;
        }

        public List<User> GetList()
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.connStr))
            {
                return _connection.Query<User>("select * from [User] where deleteflag = 0").ToList();
            }
        }

        public User GetOne(string Us_Code)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.connStr))
            {
                return _connection.QueryFirst<User>("select * from [User] where us_code = @us_code and deleteflag = 0", new { @us_code = Us_Code });
            }
        }
        public bool Delete(string Us_Code)
        {
            using (var _connection = ConnectionFactory.GetOpenConnection(this.connStr))
            {
                if( _connection.Execute("update User set deleteflag = 1 where us_code = @us_code", new { @us_code = Us_Code }) > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
