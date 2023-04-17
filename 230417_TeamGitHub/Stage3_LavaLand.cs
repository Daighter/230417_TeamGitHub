﻿using System;
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
    }

    public class LavaLand_BasicRoom1 : Stage3_LavaLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 땅 구현
        // 용암땅(화상상태이상)
        // 용암석 구조물(파괴가능, 불가능)
    }

    public class LavaLand_BuildingRoom1 : Stage3_LavaLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 건물 위치 선정
        // 땅 구현
        // NPC 위치 선정
    }

    public class LavaLand_JumpRoom3 : Stage3_LavaLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 용암땅(화상상태이상 기능)
        // 용암(빠지면 지속데미지+화상상태이상)
        // 기믹 구조물(함정, 퍼즐)
        // 점프발탄 추가
    }

    public class LavaLand_BossRoom : Stage3_LavaLand
    {
        // 배경 이미지 적용
        // 방 크기
        // 용암땅(화상상태이상 기능)
        // 용암(빠지면 지속데미지+화상상태이상)
        // 기믹 구조물(종유석 떨어짐)
        // 보스몬스터 위치 선정
    }

}
