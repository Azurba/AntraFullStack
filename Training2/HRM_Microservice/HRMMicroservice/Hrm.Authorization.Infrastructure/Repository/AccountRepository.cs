using Dapper;
using Hrm.Authorization.ApplicationLayer.Contract.Repository;
using Hrm.Authorization.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Authorization.Infrastructure.Repository
{
    public class AccountRepository : IAccountRepository
    {
        AuthenticationDapperDBContext dbContext;
        public int DeleteById(int id)
        {
            using (var conn = new SqlConnection("Data Source=.;Initial Catalog=HrmMicroserviceDapperAuthentication;Integrated Security=True")) 
            { 
                conn.Open();
                var sql = "Delete From Account Where id=@Id";
                return conn.QuerySingle(sql);
            }
        }

        public IEnumerable<IAccountRepository> GetAll()
        {
            throw new NotImplementedException();
        }

        public IAccountRepository GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(IAccountRepository obj)
        {
            throw new NotImplementedException();
        }

        public int Update(IAccountRepository obj)
        {
            throw new NotImplementedException();
        }
    }
}
