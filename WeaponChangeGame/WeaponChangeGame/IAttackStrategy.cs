namespace WeaponChangeGame;

public interface IAttackStrategy
{
    StrategyName Name { get; }
    int CalculateDamage(int damage, ArmorType armorType);
    string AttackMessage();
}