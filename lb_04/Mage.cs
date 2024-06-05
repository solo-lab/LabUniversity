namespace lb_04;

public abstract class Mage
{
    public string Name { get; private set; }
    public int MagicLevel { get; private set; }
    public int Health { get; protected set; }
    public ISpell[] Spells;

    public Mage(string name, int magicLevel, int health, ISpell[] spells)
    {
        Name = name;
        MagicLevel = magicLevel;
        Health = health;
        Spells = spells;
    }

    public abstract void Attack(Mage target, int spellIndex);
    public abstract void Defend(int damage);

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void DisplaySpells()
    {
        for (int i = 0; i < Spells.Length; i++)
        {
            Console.WriteLine($"{i + 1}: {Spells[i].GetName()}");
        }
    }
}