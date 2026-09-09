namespace WeaponChangeGame;

public class Game
{
    private const int MAX_STAGE = 3;
    private IAttackStrategy[] strategies =
    {
        new SwordAttack(),
        new BowAttack(),
        new MagicAttack()
    };
    
    Enemy[] enemies =
    {
        new Slime("파랑 슬라임", 80, 10, ArmorType.물리내성),
        new Slime("고블린 아처", 110, 30, ArmorType.원거리내성),
        new Slime("언데드 리치", 150, 40, ArmorType.마법내성)
    };
    
    public void Run()
    {
        bool isPlaying = true;
        int stageIndex = 0;
        int strategyIndex = 0;
        
        Player player = new Player("Dile", 10, 300, strategies[strategyIndex]);
        
        while (isPlaying)
        {
            Console.Clear();
            PrintMenu(player, enemies[stageIndex]);
            Console.WriteLine();
            
            Console.WriteLine("1. 공격");
            Console.WriteLine("2. 무기 변경");
            Console.WriteLine("3. 상태 확인");
            
            var picked = (GameMenu)ConsoleInput.ReadIntInRange("> ", 1, 3);
            switch (picked)
            {
                case GameMenu.공격:
                    player.Attack(enemies[stageIndex]);
                    Console.WriteLine();
                    
                    if (enemies[stageIndex].IsAlive)
                    {
                        enemies[stageIndex].Attack(player);
                    }
                    else
                    {
                        stageIndex = stageIndex < MAX_STAGE ? stageIndex + 1 : stageIndex; 
                    }
                    break;
                case GameMenu.무기변경:
                    ChangeWeapon(player);
                    break;
                case GameMenu.몬스터정보:
                    enemies[stageIndex].Info();
                    break;
            }
            
            bool enemiesDead = enemies.All(e => e.IsDead);
            
            if (player.IsDead || enemiesDead)
            {
                isPlaying = false;
                Console.WriteLine("========== END ==========");
            }
            
            ConsoleInput.Pause();
        }
    }

    public void PrintMenu(Player player, Enemy enemy)
    {
        Console.WriteLine("========= 전략 패턴 전투 =========");
        Console.WriteLine($"{player.Name} HP: {player.Hp} / {enemy.Name} HP: {enemy.Hp}");
        Console.WriteLine($"현재 전술: [{player.AttackType}]");
    }

    public void ChangeWeapon(Player player)
    {
        Console.WriteLine();
            
        Console.WriteLine("1. 롱소드");
        Console.WriteLine("2. 컴포지트보우");
        Console.WriteLine("3. 파이어볼");
        
        var picked = ConsoleInput.ReadIntInRange("> ", 1, 3);
        player.Strategy = strategies[picked - 1];
    }

    public enum GameMenu
    {
        공격 = 1,
        무기변경,
        몬스터정보
    }
}