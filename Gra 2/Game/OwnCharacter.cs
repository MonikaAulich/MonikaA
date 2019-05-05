using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class OwnCharacter:Characters
    {
        public OwnCharacter(string name, int life, int strenght, int heal)
        {
            this.name = name;
            this.life = life;
            this.strenght = strenght;
            this.heal = heal;
        }
        public override string ToString()
        {
            return name;
        }

    }
}
