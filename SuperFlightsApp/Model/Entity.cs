using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlightsApp.Model
{
    public class Entity<ID>
    {
        private ID _id;

        public Entity(ID id)
        { 
            _id = id;        
        }

        public ID Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
