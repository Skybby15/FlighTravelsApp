using SuperFlightsApp.Model;

namespace SuperFlightsApp.Repository
{
    public class RepoTickets : IRepoTickets
    {
        private readonly string ConnectionString;

        public RepoTickets(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public long AddEntity(Ticket item)
        {
            throw new NotImplementedException();
        }

        public Ticket? DeleteEntity(long id)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Ticket UpdateEntity(Ticket item)
        {
            throw new NotImplementedException();
        }
    }
}
