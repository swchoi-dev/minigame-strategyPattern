namespace WeaponChangeGame;

public abstract class Enemy
{
    private int _hp;
    private bool _isAlive;
    
    public virtual int Hp
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

    public int Damage { get; }
    public string Name { get; private set; }
    
    public bool IsAlive => _isAlive;
    public bool IsDead => !_isAlive;

    public Enemy(string name, int hp, int damage)
    {
        Name = name;
        Damage = damage;
        Hp = hp;
        _isAlive = true;
    }

    public virtual void Die()
    {
        Console.WriteLine($"{Name}은 쓰러졌다..!");
        _isAlive = false;
    }

    public virtual void Info()
    {
        Console.WriteLine($"{Name}은 {ArmorType.기본}타입 입니다.");
    }
}