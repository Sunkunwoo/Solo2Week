# Solo2Week

씬의 구성은 1, 2, 3 3개의 씬으로 구성되어있습니다.

1번 씬에서 캐릭터를 선택하고 2번 씬에서 플레이어의 최초 닉네임을 선택하는 방식으로 게임이 진행됩니다.

3번 씬으로 바로 시작시 캐릭터 타입과 플레이어의 닉네임이 없어서 정상 동작하지 않는 이슈가 있습니다.

게임매니저는 씬이 변경되어도 파괴되지않고 다음 씬에서 저장된 정보를 지속적으로 사용가능하게 만들었습니다.

현재 게임매니저에는 플레이어의 이름과 최초 접속인지 확인하는 변수만있습니다.

OnTrigger함수로 플레이어 캐릭터가 NPC의 콜리전 영역에 충돌할시 NPC와 대화하게 만들었습니다.

NPC와 대화시 TimeScale은 일시적으로 0이되도록 만들었습니다.

Npc와 최초 대화시 굿 모닝이 출력되게 하였으며 이후 대화시 디폴트로 웰컴이 나오게 하였습니다.

Exit 버튼을 누르면 다시 TimeScale이 1이 되도록 하였으며 NPC의 충돌 영역에서 나가거나 한번더 Exit 버튼을 누르면 대화창이 닫히게 하였습니다.

좌측 상단의 'rename'과 'choice'로 플레이어의 이름과 캐릭터를 변경 가능하게 만들었습니다.

플레이어의 이름은 우측 상단에 표시됩니다.

현재 시간은 이름 하단에 노출되게 하였습니다.

캐릭터 이동시 마우스 포인터를 캐릭터가 바라보는게 아닌 캐릭터가 이동하는 방향을 바라보게 하였습니다.
