using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFlightsApp.Model;

namespace SuperFlightsApp.Repository
{
    public interface IRepository <Item,ID> where Item : Entity<ID>
    {

        public List<Item> GetAllEntities();
        public ID AddEntity(Item item);
        public Item? DeleteEntity(ID id);
        public Item UpdateEntity(Item item);

    }
}
