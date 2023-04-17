using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230417_TeamGitHub
{
    public class Monster
    {
        protected int id;
        protected string name;
        protected int hp;
        protected int atk;
        public void Attack(int atk)
        {
            // 몬스터가 공격한다
        }
        public void TakeDamage(int damage)
        {
            // 몬스터가 데미지를 받는다
            hp -= damage;
        }
    }

    public class Slime : Monster
    {
        // 슬라임 구현
    }
}
