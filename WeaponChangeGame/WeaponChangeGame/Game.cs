namespace WeaponChangeGame;

public class Game
{
    public void Run()
    {
        // 유저 입력받아서
        
        // 유저가 공격하면
        // Player.Attack();
        // Monster.TakeDamage(Player.damage, Player.AttackStrategy);
        
        // 몬스터들 반격
        // Monster.Attack();
        // Player.TakeDamage(Monster.damage, Monster.AttackStrategy);

        SwordAttack swordAttack = new SwordAttack();
        Player player = new Player("Dile", 10, 300, swordAttack);
        Slime slime = new Slime("파랑 슬라임", 100, 30, ArmorType.물리내성);
        slime.Attack(player);
        slime.TakeDamage(30);
        slime.Info();


    }
}