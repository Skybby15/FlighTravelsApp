using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFlightsApp.Model;

namespace SuperFlightsApp.Repository
{
    public interface IRepoTickets : IRepository<Ticket,long>
    {
    }
}
