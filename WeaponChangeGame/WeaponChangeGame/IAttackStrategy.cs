namespace WeaponChangeGame;

public interface IAttackStrategy
{
    int CalculateDamage(int damage, ArmorType armorType);
    string AttackMessage();
}