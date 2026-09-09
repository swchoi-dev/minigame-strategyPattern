namespace WeaponChangeGame;

public class BowAttack : IAttackStrategy
{
    public StrategyName Name => StrategyName.원거리공격;
    
    public int CalculateDamage(int damage, ArmorType armorType)
    {
        int result = armorType switch
        {
            ArmorType.기본 => damage,
            ArmorType.물리내성 => damage,
            ArmorType.원거리내성 => damage / 10,
            ArmorType.마법내성 => damage + 30,
            _ => damage
        };
        return result;
    }

    public string AttackMessage()
    {
        return "활로 원거리공격..!";
    }
}