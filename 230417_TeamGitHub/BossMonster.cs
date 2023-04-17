using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230417_TeamGitHub
{
    public class BossMonster : EliteMonster
    {
        // 굉장히 굉장하게 굉장한 보스몬스터. 엘리트 몹보다 훨씬 강하다.
        public virtual void Passive()
        {
            // 일반몹은 없는 특별한 패시브 스킬. 보스는 만만하지 않다!
        }
    }
    public class GiganticGolem : BossMonster
    {
        public override void Skill()
        {
            // 스타 라이트 브레이커-!....가 아니라 그냥 굉장한 빔. 맞으면 녹아버릴지도?
        }
        public override void Passive()
        {
            // 이것은 골렘의 외피입니다. 끔찍하게 튼튼하죠. 물리공격에 매우 높은 내성을 지닙니다.
        }
    }

    public class RedDragon : BossMonster
    {
        public override void Skill()
        {
            // 퐈이야아아아아아아아아아아아! 굉장히 뜨거운 브레스. 광역공격이다.
        }
        public override void Passive()
        {
            // 용의 비늘은 모든 데미지를 99% 줄여서 받는다! 하지만 단 하나 있는 역린을 공격하면 10배의 데미지를 받는다!
        }
    }

    public class CorruptedKnight : BossMonster
    {
        // 타락한 기사. 강하다. 정화하면 동료가 될지도?
        public override void Skill() 
        {
            // 단순한 내려베기. 단순하지만 생전에 일평생 수련한 내려베기는 절대 무시할만한 공격이 아니다.
        }
        public override void Passive() 
        {
            // 타락해서 이성을 잃었다. 모든 신체능력이 상승된 대신 마력을 사용하지 못한다.
        }
    }
}
