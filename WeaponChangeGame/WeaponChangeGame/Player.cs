namespace WeaponChangeGame;

public class Player : IAttack, ITakeDamage
{
    private int _hp;
    private IAttackStrategy _strategy;
    
    public string Name { get; }
    public int Damage { get; }
    
    public bool IsAlive { get; private set; }

    public ArmorType ArmorType { get; }
    
    public int Hp
    {
        get => _hp;
        protected set
        {
            if (value < 0) value = 0;
            _hp = value;
            if (_hp <= 0) Die();
            else Console.WriteLine($"{Name}의 체력은 {Hp}이 되었다..!");
        }
    }

    public Player(string name, int damage, int hp, IAttackStrategy strategy)
    {
        Name = name;
        Damage = damage;
        Hp = hp;
        _strategy = strategy;
        ArmorType = ArmorType.기본;
        IsAlive = true;
    }
    public void Attack(ITakeDamage enemy)
    {
        _strategy.CalculateDamage(Damage, enemy.ArmorType);
        Console.WriteLine($"{_strategy.AttackMessage()}");
        enemy.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Console.WriteLine($"{Name}은 {damage}의 데미지를 입었다..!");
        Hp -= damage;
    }
    
    public void Die()
    {
        Console.WriteLine($"{Name}은 사망했다..!");
        Console.WriteLine($"{Name}의 눈 앞이 깜깜해졌다..!");
        IsAlive = false;
    }
}