using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace Blog.DAL
{
    public class BlogDbConnection
    {
        public BlogDbConnection(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration;

        private IDbConnection connection { get; set; }


        public IDbConnection GetDbConnection(int DbType = 1)
        {
            switch (DbType)
            {
                case 1:
                    connection = new SqlConnection(Configuration.GetConnectionString("DefaultConnectionString"));
                    break;
                case 2:
                    connection = new MySqlConnection(Configuration.GetConnectionString("DefaultConnectionString"));
                    break;
                case 3:
                    connection = new OracleConnection(Configuration.GetConnectionString("DefaultConnectionString"));
                    break;
                default:
                    connection = new SqlConnection(Configuration.GetConnectionString("DefaultConnectionString"));
                    break;
            }
            connection.Open();
            return connection;
        }

    }
}
