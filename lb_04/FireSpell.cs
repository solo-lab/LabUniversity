namespace lb_04;

public class FireSpell : ISpell
{
    private int _damage;

    public FireSpell(int damage)
    {
        _damage = damage;
    }

    public void Cast(Mage target)
    {
        Console.WriteLine($"Fire spell deals {_damage} damage to {target.Name}");
        target.Defend(_damage);
    }

    public string GetName()
    {
        return "Fire Spell";
    }
}