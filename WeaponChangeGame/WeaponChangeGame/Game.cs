namespace WeaponChangeGame;

public class Game
{
    public void Run()
    {
        bool isPlaying = true;
        bool enemiesDead = false;
        int stageIndex = 0;
        int strategyIndex = 0;
        IAttackStrategy[] strategies =
        {
            new SwordAttack(),
            new BowAttack(),
            new MagicAttack()
        };
        Enemy[] enemies =
        {
            new Slime("파랑 슬라임", 100, 30, ArmorType.물리내성)
        };
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
                    break;
                case GameMenu.무기변경:
                    break;
                case GameMenu.몬스터정보:
                    enemies[stageIndex].Info();
                    break;
            }

            foreach (Enemy enemy in enemies)
            {
                if (enemy.IsAlive)
                {
                    enemiesDead = false;
                }
            }
            
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

    public enum GameMenu
    {
        공격 = 1,
        무기변경,
        몬스터정보
    }
}