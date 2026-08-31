namespace WeaponChangeGame;

public class Slime : Enemy, IAttack, ITakeDamage
{
    public Slime(string name, int hp, int damage) : base(name, hp, damage)
    {
        
    }

    public void Attack()
    {
        Console.WriteLine($"{Name}이 강력하게 몸을 부딪혔다..!");
        Console.WriteLine($"{Damage}만큼의 피해를 입혔다..!");
    }

    public void TakeDamage(int damage)
    {
        Hp -= damage;
        Console.WriteLine($"{Name}은 {damage}의 데미지를 입었다..!");
    }
}