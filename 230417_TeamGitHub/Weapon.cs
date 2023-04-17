using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230417_TeamGitHub
{
    internal class Weapon
    {
        protected string name;
        protected int attackPoint;
        public Weapon(string name, int attackPoint)
        {
            this.name = name;
            this.attackPoint = attackPoint;
        }
    }
}
