namespace WeaponChangeGame;

public class MagicAttack : IAttackStrategy
{
    public StrategyName Name => StrategyName.마법공격;
    
    public int CalculateDamage(int damage, ArmorType armorType)
    {
        int result = armorType switch
        {
            ArmorType.기본 => damage,
            ArmorType.물리내성 => damage + 30,
            ArmorType.원거리내성 => damage,
            ArmorType.마법내성 => damage / 10,
            _ => damage
        };
        Console.WriteLine($"damage : {result}");
        return result;
    }

    public string AttackMessage()
    {
        return "마법으로 공격..!";
    }
}