using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legend_of_prawn
{
    class Player
    {
        private string name = "Prawn";
        private int maxHP = 100;
        private int hp = 100;

        public string Name {
            get { return this.name; }
        }

        public int HP {
            get { return this.hp; }
        }

        public int MaxHP {
            get { return this.maxHP;  }
        }

        public void TakeDamage(int damage) {
            this.hp -= damage;
        }
    }
}
