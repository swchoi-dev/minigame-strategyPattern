namespace WeaponChangeGame;

public class Slime : Enemy, IAttack, ITakeDamage
{
    public ArmorType ArmorType { get; }
    
    public Slime(string name, int hp, int damage, ArmorType armor) : base(name, hp, damage)
    {
        ArmorType = armor;
    }

    public void Attack(ITakeDamage player)
    {
        Console.WriteLine($"{Name}이 강력하게 몸을 부딪혔다..!");
        Console.WriteLine($"{Damage}만큼의 피해를 입혔다..!");
        player.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Console.WriteLine($"{Name}은 {damage}의 데미지를 입었다..!");
        Hp -= damage;
    }

    public override void Info()
    {
        Console.WriteLine($"{Name}은 {ArmorType}타입 입니다.");
        Console.WriteLine($"{Name}은 물리 공격에 데미지가 90% 반감됩니다.");
    }
}