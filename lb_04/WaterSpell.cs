namespace lb_04;

public class WaterSpell : ISpell
{
    private int _damage;

    public WaterSpell(int damage)
    {
        _damage = damage;
    }

    public void Cast(Mage target)
    {
        Console.WriteLine($"Water spell deals {_damage} damage to {target.Name}");
        target.Defend(_damage);
    }

    public string GetName()
    {
        return "Water Spell";
    }
}