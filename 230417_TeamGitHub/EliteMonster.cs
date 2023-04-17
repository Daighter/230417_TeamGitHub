using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230417_TeamGitHub
{
    public class EliteMonster : Monster
    {
        // 해당 클래스를 상속한 몬스터는 더 강려크해진다
        public virtual void Skill()
        {
            // 스킬을 쓴다. 오버라이딩 해서 무슨 스킬일지 정한다.
        }
    }
    public class EliteOrc : EliteMonster
    {
        // 더 강한 오크. 근육이 늘었다. 그뉵그뉵.
        public override void Skill()
        {
            // 분노분노분노하는 스킬
        }
    }
    public class EliteZombie : EliteMonster
    {
        // 더 강한 좀비. 물리면 디버프에 걸린다.
        public override void Skill()
        {
            // 이 좀비는 무해하지 않고 물지 않지 않습니다.
        }
    }
    public class EliteSlime : EliteMonster
    {
        // 더 강한 슬라임. 겉보기에는 일반 슬라임과 똑같아 보일수도 있다
        public override void Skill()
        {
            // 이 슬라임은 서식중인 환경에 따라 속성이 변한다! 변한 속성에는 내성이 있으니 주의하도록 하자.
        }
    }
}
