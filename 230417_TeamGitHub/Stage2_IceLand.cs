using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230417_TeamGitHub
{
    public class Stage2_IceLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 건물 위치
        // NPC 위치 
        // 얼음땅 구현(부서지는 땅 및 괜찮은땅)
        // 얼음 미끌거림 기능
        // 얼음 관련 구조물 구현(배경 및 파괴 상호작용)_(추상)
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

    public class IceLand_BasicRoom1 : Stage2_IceLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 얼음땅 구현(부서지는 땅 및 괜찮은땅)
        // 얼음 미끌거림 기능
        // 얼음 관련 구조물 구현(배경 및 파괴 상호작용)_(추상)
        // 기믹 구조물 구현(함정, 퍼즐)_(추상)
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

    public class IceLand_BuildingRoom2 : Stage2_IceLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 건물 위치 선정
        // NPC 위치 선정
        // 얼음땅 구현(괜찮은땅)
        // 얼음 미끌거림 기능 추가
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

    public class IceLand_JumpRoom3 : Stage2_IceLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 얼음땅 구현(부서지는 땅 및 괜찮은땅)
        // 얼음 미끌거림 기능
        // 얼음 관련 구조물 구현(배경 및 파괴 상호작용)_(추상)
        // 기믹 구조물 구현(함정, 퍼즐)_(추상)
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

    public class IceLand_BossRoom : Stage2_IceLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 얼음땅 구현(부서지는 땅 및 괜찮은땅)
        // 얼음 미끌거림 기능
        // 보스몬스터 위치 선정
        // 스페이지 이동
        public override void MapMove()
        {
            // 맵과맵 및 다음 스테이지 이동관련 기능
        }
    }



}
