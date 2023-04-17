using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _230417_TeamGitHub
{
    public class Player
    {
        protected string name;
        public int hp;
        public int ap;
        public int mp;
        public int dp;

        public Player(string name, int hp, int ap, int mp)
        {
            this.name = name;    
            this.hp = hp;
            this.ap = ap;
            this.mp = mp;
        }
        public void TrueDamage(int damage)
        {
            Console.WriteLine($"{name}가 {damage}의 피해를 받았다.");
        }
        public void Attack(int damage)
        {
            Console.WriteLine($"{name}가 {damage}의 피해를 입혔다");
        }

    }
}