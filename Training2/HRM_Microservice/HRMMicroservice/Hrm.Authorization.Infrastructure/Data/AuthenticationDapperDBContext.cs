using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hrm.Authorization.Infrastructure.Data
{
    public class AuthenticationDapperDBContext
    {
        SqlConnection dbConnection;
        IConfiguration configuration;
        public AuthenticationDapperDBContext()
        {
            //Open the connection with the database
            dbConnection = new SqlConnection("Data Source=.;Initial Catalog=HrmMicroserviceDapperAuthentication;Integrated Security=True");
            //Another way of doing it
            //dbConnection = new SqliteConnection("Data Source=.;Initial Catalog=JanBatch2023;Integrated Security=True");
        }
        //Method to Get the connection
        public SqlConnection GetConnection()
        {
            return dbConnection;
        }

        //You can also pass to the constructor the configuration for the connection
        public AuthenticationDapperDBContext(IConfiguration config)
        {
            configuration = config;
        }
    }
}
