using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace Blog.DAL
{
    public class ConnectionFactory
    {
        public static DbConnection GetOpenConnection(string connstr)
        {
            var connection = new SqlConnection(connstr);
            connection.Open();
            return connection;
        }
    }
}
