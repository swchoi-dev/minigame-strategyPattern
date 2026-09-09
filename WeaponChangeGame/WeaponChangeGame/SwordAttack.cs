namespace WeaponChangeGame;

public class SwordAttack : IAttackStrategy
{
    public StrategyName Name => StrategyName.물리공격;
    
    public int CalculateDamage(int damage, ArmorType armorType)
    {
        int result = armorType switch
        {
            ArmorType.기본 => damage,
            ArmorType.물리내성 => damage / 10,
            ArmorType.원거리내성 => damage + 30,
            ArmorType.마법내성 => damage,
            _ => damage
        };
        return result;
    }

    public string AttackMessage()
    {
        return "검으로 물리공격..!";
    }
}