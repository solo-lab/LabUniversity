﻿namespace lb_04;

public class FireMage : Mage
{
    public FireMage(string name, int magicLevel, int health, ISpell[] spells) 
        : base(name, magicLevel, health, spells)
    {
    }

    public override void Attack(Mage target, int spellIndex)
    {
        Console.WriteLine($"{Name} casts a fire spell on {target.Name}!");
        Spells[spellIndex].Cast(target);
    }

    public override void Defend(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage, remaining health: {Health}");
    }
}