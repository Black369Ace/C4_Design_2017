using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _098
{
    class Character
    {
        protected int BaseDamage;
        public int Hp;
        protected NormalAttack normalAttack;

        public Character(int Hp, int BaseDamage)
        {
            Hp = 40;
            BaseDamage = 10;
        }
        

       public void AttackChar(Character Target)
        {          
           // ???
        }

    }
}