using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230417_TeamGitHub
{
    internal class DuelSword : Weapon
    {
        public DuelSword(string name, int attackPoint) : base(name, attackPoint)
        {
            // 사정거리 매우짧음
            // 공격력 매우 낮음
            // 공격속도 매우 빠름
            // 착용자에게 민칩함 추가부여
        }
    }
}
