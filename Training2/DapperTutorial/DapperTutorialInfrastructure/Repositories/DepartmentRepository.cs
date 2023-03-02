using DapperTutorialCore.Contracts.Repositories;
using DapperTutorialCore.Entities;
using DapperTutorialInfrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialInfrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        DapperDBContext dbContext;
        public DepartmentRepository()
        { 
            //This invokes our connection
            dbContext= new DapperDBContext();
            
        }
        public int DeleteById(int id)
        {

            using (var conn = new SqlConnection("Data Source=.;Initial Catalog=JanBatch2023;Integrated Security=True")) 
            {
                conn.Open();
                var sql = "Delete From Department Where Id=@Id";
                return conn.QuerySingle(sql);
            };
            
        }

        public IEnumerable<Department> GetAll()
        {
            using (var conn = dbContext.GetConnection())
            {
                return conn.Query<Department>("Select Id, name, Location From Department");
            };
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Task obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Task obj)
        {
            throw new NotImplementedException();
        }
    }
}
