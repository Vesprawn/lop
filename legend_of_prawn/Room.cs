using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legend_of_prawn
{
    class Room
    {
        private int id;

        public int Id {
            get { return this.id; }
        }

        public Room(int pId) {
            this.id = pId;
        }
    }
}
