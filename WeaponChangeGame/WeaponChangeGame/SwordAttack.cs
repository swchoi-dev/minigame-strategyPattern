namespace WeaponChangeGame;

public class SwordAttack : IAttackStrategy
{
    public StrategyName Name => StrategyName.물리공격;
    
    public int CalculateDamage(int damage, ArmorType armorType)
    {
        return 0;
    }

    public string AttackMessage()
    {
        return "검으로 물리공격..!";
    }
}