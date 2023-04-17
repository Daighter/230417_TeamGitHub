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
    public class Mimic : EliteMonster
    {
        // 미믹이다. 다른 엘리트들보단 비교적 약하지만 무시하다간 한방에 주님곁으로 보내질수도 있다.
        public override void Skill() 
        {
            // 위장. 던전의 오브젝트로 위장한다. 상호작용 시 혹은 공격을 받을 시 위장을 풀며 공격한다.
        }
    }

    public class Demon : EliteMonster
    {
        // 허접한 레서 데몬이 아닌 정식 악마. 평범하게 강하다. 화염내성이 비교적 높은것이 특징
        public override void Skill()
        {
            // 악마는 본신의 힘만으로 싸우지 않는다. 레서 데몬들을 소환해서 비겁하게 물량공세를 하는것이 사악한 악마에게 맞는 전법일것이다.
            // 그래서 스킬이 뭐냐고요? 하수인 소환입니다~ ^^7
        }
    }
    public class EarthElemental : EliteMonster
    {
        // 지정령. 튼튼하다. 골렘처럼 생겼다.
        public override void Skill()
        {
            // 땅속으로 숨을 수 있다. 두더지처럼 튀어나온다고 무시하는건 좋은 생각이 아니다.
            // 이게 두더지가 아니라 신장 5미터의 거대 골렘이라는걸 기억하자.
        }
    }
}
