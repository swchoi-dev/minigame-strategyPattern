namespace WeaponChangeGame;

public class Game
{
    public void Run()
    {
        bool isPlaying = true;
        SwordAttack swordAttack = new SwordAttack();
        Player player = new Player("Dile", 10, 300, swordAttack);
        Slime slime = new Slime("파랑 슬라임", 100, 30, ArmorType.물리내성);
        
        while (isPlaying)
        {
            Console.Clear();
            PrintMenu(player, slime);
            
            // PrintKioskMain(itemList);
            //
            // var picked = (KioskMenu)ConsoleInput.ReadIntInRange("번호 : ", 1, 4);
            // switch (picked)
            // {
            //     case KioskMenu.담기:
            //         // 메뉴번호와 수량을 묻기
            //         OrderItem(itemList);
            //         break;
            //     case KioskMenu.전체비우기:
            //         // 장바구니 통째로 비우기
            //         ClearShoppingCart(itemList);
            //         break;
            //     case KioskMenu.결제:
            //         // 합계 금액 출력, 받은 금액 묻기
            //         PayShoppingCart();
            //         ClearShoppingCart(itemList);
            //         break;
            //     case KioskMenu.영업종료:
            //         // 그날의 총 주문건수와 총 매출액 출력
            //         isStoreOpen = false;
            //         CloseStore();
            //         break;
            // }
            if (player.IsDead || slime.IsDead)
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
        Console.WriteLine($"현재 전술: {player.AttackType}");
    }
}