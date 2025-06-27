using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFlightsApp.Model;
using SuperFlightsApp.Utils;

namespace SuperFlightsApp.Repository
{
    public class RepoFlights : IRepoFlights
    {
        private readonly string ConnectionString;

        public RepoFlights(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public long AddEntity(Flight item)
        {
            throw new NotImplementedException();
        }

        public Flight? DeleteEntity(long id)
        {
            throw new NotImplementedException();
        }

        public List<Flight> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Flight UpdateEntity(Flight item)
        {
            throw new NotImplementedException();
        }
    }
}
