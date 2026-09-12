# 전략 패턴 + 무기 바꾸기 미니 RPG

전략 패턴은 “누가 공격하는가”가 아니라 **“지금 어떤 방식으로 공격하는가”를 객체로 만든 것** 으로
간단히 콘솔게임을 만들어서 전략패턴을 사용하면 구조적으로 어떻게 편해지는지 직접 경험해봤다.

## 무엇을 분리했나

| 역할 | 코드 | 하는 일 |
|------|------|---------|
| 맥락(Context) | `Player` | 공격 버튼을 누른다. 방식은 모른다. |
| 전략(Strategy) | `IAttackStrategy` | 공격 방식의 약속 |
| 구체 전략 | `SwordAttack`, `BowAttack`, `MagicAttack` | 실제 데미지/연출 |
| 교체 | `Player.SetStrategy(...)` | 무기만 갈아끼운다 |

플레이어를 고치지 않고 무기만 바꿔도 공격이 바뀐다.

```text
Player
  └─ IAttackStrategy
        ├─ SwordAttack
        ├─ BowAttack
        └─ MagicAttack
```

## 조작

게임 루프는 `Program.Main` → `Game`으로 들어간다.

- 숫자 키로 행동 선택 (공격 / 무기 교체 / 다음 스테이지 등)
- 무기 교체 시 `SetStrategy`만 호출한다
- 적은 `Enemy` 계층으로 등장한다

실제 키 안내는 실행 후 콘솔 출력과 `ConsoleInput`을 보면 된다.

## Unity로 옮길 때

콘솔의 전략 객체를 아래처럼 바꾸면 된다.

- 무기 프리팹에 `IAttackStrategy` 구현 컴포넌트
- 또는 `ScriptableObject`로 무기 데이터 + 공격 로직
- 적 AI는 `IAttackStrategy` 대신 `IAiBehaviour` 같은 전략으로 같은 구조

## 구조

```text
IAttackStrategy
Player          SetStrategy / Attack
SwordAttack
BowAttack
MagicAttack
Enemy           Slime, GoblinArcher, UndeadRich ...
Game            스테이지 / 루프
ConsoleInput    입력
```
