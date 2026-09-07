namespace WeaponChangeGame;

public class BowAttack : IAttackStrategy
{
    public StrategyName Name => StrategyName.원거리공격;
    
    public int CalculateDamage(int damage, ArmorType armorType)
    {
        return 0;
    }

    public string AttackMessage()
    {
        return "활로 원거리공격..!";
    }
}