namespace WeaponChangeGame;

public abstract class Enemy
{
    public int Hp { get; private set; }
    public int Damage { get; private set; }
    public string Name { get; private set; }

    public Enemy(string name, int hp, int damage)
    {
        Name = name;
        Hp = hp;
        Damage = damage;
    }
}