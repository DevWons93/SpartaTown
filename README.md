# SpartaTown
 Unity2DProject

 
# 개발 환경
* UNITY 2022.3.17fl(LTS)
---
# 기능 구현
1. 필수 구현
   1. 캐릭터 구현
   2. 캐릭터 이동
      UnitController.cs : 유닛의 이동 및 시선 이벤트 처리
      PlayerInputController.cs : 플레이어의 입력을 처리
      UnitMovement.cs : 이동, 대시, 시선 변화에 대한 로직 구현
      UnitAimRotation.cs : 마우스 포인터의 위치에 따른 플레이어 SpriteRenderer flip 로직 구현
   3. 방만들기
   4. 카메라 따라가기
      CameraFollow.cs
   5. 캐릭터 애니메이션 추가
      AnimationController.cs
      PlayerAnimationController.cs : 플레이어 행동 이벤트에서 호출될 애니메이터 파라미터 처리 로직 구현
   6. 이름 입력 시스템
      LoginButton.cs
2. 선택 구현
   1. 시간표시
      TimeDisplay.cs
   2. 인게임 이름 바꾸기
      MenuBar.cs
   3. 참석 인원 UI
      UserList.cs
      
