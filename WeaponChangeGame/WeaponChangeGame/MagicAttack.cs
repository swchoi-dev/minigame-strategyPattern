namespace WeaponChangeGame;

public class MagicAttack : IAttackStrategy
{
    public StrategyName Name => StrategyName.마법공격;
    
    public int CalculateDamage(int damage, ArmorType armorType)
    {
        return 0;
    }

    public string AttackMessage()
    {
        return "마법으로 공격..!";
    }
}