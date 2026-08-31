namespace WeaponChangeGame;

public class Player : IAttack, ITakeDamage, IAttackStrategy
{
    public void Attack()
    {
        
    }

    public void TakeDamage(int damage)
    {
        
    }

    public int CalculateDamage(int damage)
    {
        return damage;
    }
}