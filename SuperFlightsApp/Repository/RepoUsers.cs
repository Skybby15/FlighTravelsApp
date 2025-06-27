using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFlightsApp.Model;

namespace SuperFlightsApp.Repository
{
    public class RepoUsers : IRepoUsers
    {
        private readonly string ConnectionString;

        public RepoUsers(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public long AddEntity(User item)
        {
            throw new NotImplementedException();
        }

        public User? DeleteEntity(long id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public User? GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User UpdateEntity(User item)
        {
            throw new NotImplementedException();
        }
    }
}
