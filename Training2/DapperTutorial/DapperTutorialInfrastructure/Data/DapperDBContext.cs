using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialInfrastructure.Data
{
    
    public class DapperDBContext
    {
        SqlConnection dbConnection;
        IConfiguration configuration;

        public DapperDBContext()
        {
            //Open the connection with the database
            dbConnection = new SqlConnection("Data Source=.;Initial Catalog=JanBatch2023;Integrated Security=True");
            //Another way of doing it
            //dbConnection = new SqliteConnection("Data Source=.;Initial Catalog=JanBatch2023;Integrated Security=True");
        }
        //Method to Get the connection
        public SqlConnection GetConnection()
        { 
            return dbConnection; 
        }


        //You can also pass to the constructor the configuration for the connection
        public DapperDBContext(IConfiguration config)
        {
            configuration = config;
        }






    }
}
