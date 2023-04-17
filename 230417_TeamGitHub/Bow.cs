using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230417_TeamGitHub
{
    internal class Bow : Weapon
    {
        public Bow(string name, int attackPoint) : base(name, attackPoint)
        {
            // 사정거리 개인차 있음
            // 공격속도 조금 빠름
            // 공격력 화살에 따라 다름
        }
    }
}
