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
}
