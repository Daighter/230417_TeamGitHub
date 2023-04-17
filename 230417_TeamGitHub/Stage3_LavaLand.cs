using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230417_TeamGitHub
{
    public class Stage3_LavaLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 건물 위치
        // NPC 위치 
        // 땅 구현
        // 용암땅 구현(화상상태이상 기능)
        // 용암 구현(빠지면 지속데미지+화상상태이상)
        // 용암석 구조물(파괴가능, 불가능)
        // 기믹 구조물 구현(함정, 퍼즐)_(추상)
        // 보물상자 구성(아이템과 연결)
        // 점프발판 구성
        // 워프구조물 구현
        // 맵이동 구조물 구현
        public virtual void Destruction()
        {
            // 파괴 기능 구현
        }
        public virtual void Damage()
        {
            // 함정 관련 피격 데미지 구현
        }
        public virtual void Sensing()
        {
            // 함정 또는 구조물등 플레이어를 감지하고 상호작용 되는 기능
        }
        public virtual void PuzzleActive()
        {
            // 퍼즐 구조물 관련 움직임 기능
        }
        public void TreasureBox()
        {
            // 보물상자 상호작용
        }
        public void Bounce()
        {
            // 점프발판 기믹 관련 기능
        }
        public void Warp()
        {
            // 워프석과 상호작용
        }
        public virtual void MapMove()
        {
            // 맵과맵 및 다음 스테이지 이동관련 기능
        }
    }

    public class LavaLand_BasicRoom1 : Stage3_LavaLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 땅 구현
        // 용암땅(화상상태이상)
        // 용암석 구조물(파괴가능, 불가능)
        // 보물상자 위치 선정(아이템과 연결)
        // 워프석 위치 선정
        // 맵이동 구조물 구현
        public virtual void Destruction()
        {
            // 파괴 기능 구현
        }
        public void TreasureBox()
        {
            // 보물상자 상호작용
        }
        public void Warp()
        {
            // 워프석과 상호작용
        }
        public void MapMove()
        {
            // 맵과맵 및 다음 스테이지 이동관련 기능
        }
    }

    public class LavaLand_BuildingRoom1 : Stage3_LavaLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 건물 위치 선정
        // 땅 구현
        // NPC 위치 선정
        // 워프석 위치 선정
        // 맵이동 구조물 구현
        public void Warp()
        {
            // 워프석과 상호작용
        }
        public void MapMove()
        {
            // 맵과맵 및 다음 스테이지 이동관련 기능
        }
    }

    public class LavaLand_JumpRoom3 : Stage3_LavaLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 용암땅(화상상태이상 기능)
        // 용암(빠지면 지속데미지+화상상태이상)
        // 기믹 구조물(함정, 퍼즐)
        // 점프발판
        public void Bounce()
        {
            // 점프발판 기믹 관련 기능
        }
        public void MapMove()
        {
            // 맵과맵 및 다음 스테이지 이동관련 기능
        }

    }

    public class LavaLand_BossRoom : Stage3_LavaLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 용암땅(화상상태이상 기능)
        // 용암(빠지면 지속데미지+화상상태이상)
        // 기믹 구조물(종유석 떨어짐)
        // 보스몬스터 위치 선정
        // 스페이지 이동
        public override void MapMove()
        {
            // 맵과맵 및 다음 스테이지 이동관련 기능
        }
    }

}
