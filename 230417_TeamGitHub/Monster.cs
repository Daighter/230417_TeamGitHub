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

    public class Orc : Monster 
    {
        // 초록색 오크
    }

    public class Goblin : Monster 
    {
        // 더 초록색 고블린
    }

    public class Zombie : Monster 
    {
        // 좀비같이 생긴 좀비
    }
    public class EliteMonster : Monster
    {
        // 해당 클래스를 상속한 몬스터는 더 강려크해진다
        public virtual void Skill()
        {
            // 스킬을 쓴다. 오버라이딩 해서 무슨 스킬일지 정한다.
        }
    }
}
