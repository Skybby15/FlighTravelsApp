using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFlightsApp.Model;

namespace SuperFlightsApp.Repository
{
    public interface IRepoUsers : IRepository<User,long>
    {
        public User? GetUserByEmail(string email);
    }
}
