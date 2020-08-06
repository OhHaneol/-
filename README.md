# Unity Practice


<details markdown="1">
<summary>1. Dodge</summary>

------------------------
<details markdown="1">
<summary>1. 게임 설명</summary>

## 게임 설명
>사방에서 날아오는 총알을 가능한 한 피하는 탄막 슈팅 게임.<br>
>+조작법+<br>
>움직이기: 키보드 방향키 또는 WASD키<br>
>(사망 후)게임 재시작: R키
>>1. 플레이어 주변은 벽으로 막혀 있고, 바닥은 계속 회전한다. 사방에 배치된 붉은 기둥이 플레이어를 향해 총알을 발사한다.<br>
>>2. 총알은 플레이어의 최근 위치로 발사된다.<br>
>>3. 플레이어가 버틴 시간이 UI로 표시된다.<br>
>>4. 총알에 맞아 플레이어가 죽으면 게임오버 텍스트와 최고기록이 표시된다. 게임오버 시 R 키를 누르면 게임을 재시작한다.<br>
</details>

<details markdown="1">
<summary>2. 제작 과정</summary>

## 제작 과정
>1. 바닥과 벽 제작
>>1. 새로운 프로젝트를 생성 후 바닥 Plane 오브젝트 만들기.(Hierarchy > Create > 3D Object > Plane)<br>인스펙터 창에서 Plane 오브젝트의 Transform 컴포넌트의 스케일을 (2, 1, 2)로 변경<br>Plane 오브젝트에 색을 입히기 위해 새로 머터리얼 생성(Project > Create > Material) 후 이름을 Plane Color로 변경.<br>생성된 Plane Color 머터리얼을 선택하여 알베도의 컬러 필드에서 검은색으로 변경.<br>Plane Color 머터리얼을 씬 창의 Plane 게임 오브젝트로 드래그&드롭.
>>2. Cube 오브젝트로 벽 생성(Hierarchy > Create > 3D Object > Cube) 후 이름을 Wall로 변경.<br>인스펙터 창에서 Position은 (0, 0.5, 0), Scale은 (20, 1, 1)로 변경.<br>하이어라키 창에서 Wall 게임 오브젝트를 선택 후 [Command+D]로 3개 더 복제하여 나머지 Position에 배치.<br>하이어라키 창에서 Create Empty로 빈 게임 오브젝트 생성 후 Name을 Level로 변경.<br>Level 오브젝트의 위치 리셋(Transform > 톱니바퀴 > Reset).<br>하이어라키 창에서 [Shift+클릭]으로 Plane, Wall 4개 모두 선택 후 Level 게임 오브젝트로 드래그&드롭하여 자식으로 넣기.

>2. 플레이어 제작
>>
>3. 탄알 제작
>>
</details>

<details markdown="1">
<summary>3. method/class</summary>

## method/class

</details>

------------------------
</details>



<details markdown="1">
<summary>2. UniRun</summary>

------------------------
<details markdown="1">
<summary>1. 게임 설명</summary>

## 게임 설명
>설명<br>
>+조작법+<br>
>움직이기: 키보드 방향키 또는 WASD키<br>
>(사망 후)게임 재시작: R키
>>1. 조건1<br>
>>2. 조건2..
</details>

<details markdown="1">
<summary>2. 제작 과정</summary>

## 제작 과정

</details>

<details markdown="1">
<summary>3. method/class</summary>

## method/class

</details>

------------------------
</details>


