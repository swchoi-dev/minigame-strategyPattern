namespace WeaponChangeGame;

public abstract class Enemy
{
    private int _hp;

    public virtual int Hp
    {
        get => _hp;
        protected set
        {
            if (value < 0) value = 0;
            _hp = value;
            if (_hp <= 0) Die();
        }
    }

    public int Damage { get; }
    public string Name { get; private set; }

    public Enemy(string name, int hp, int damage)
    {
        Name = name;
        Hp = hp;
        Damage = damage;
    }

    public virtual void Die()
    {
        Console.WriteLine($"{Name}은 쓰러졌다..!");
    }
}