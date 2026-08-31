namespace WeaponChangeGame;

public interface ITakeDamage
{
    ArmorType ArmorType { get; }
    void TakeDamage(int damage);
}