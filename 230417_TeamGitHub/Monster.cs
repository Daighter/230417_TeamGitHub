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

    public class GoldenGoblin : Goblin
    {
        // 황금 고블린이다. 죽이면 좋은 템을 드랍한다.
    }

    public class Bat : Monster
    {
        // 흡혈박쥐다. 체력은 허접하지만 공격할때마다 피를 빨아먹으니 한방에 처리하도록 하자.
    }

    public class lesserDemon : Monster
    {
        // 레서 데몬. 비교적 튼튼하고 강하다. 하지만 특별한 능력은 없다.
    }
}
