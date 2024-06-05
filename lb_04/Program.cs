using System;

namespace lb_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Набори заклять
            ISpell[] fireMageSpells = new ISpell[] { new FireSpell(30), new FireSpell(40) };
            ISpell[] waterMageSpells = new ISpell[] { new WaterSpell(25), new WaterSpell(35) };

            // Створення магів
            Mage fireMage = new FireMage("FireMage", 5, 100, fireMageSpells);
            Mage waterMage = new WaterMage("WaterMage", 5, 100, waterMageSpells);

            Console.WriteLine("The battle begins!");

            while (fireMage.IsAlive() && waterMage.IsAlive())
            {
                PlayerTurn(fireMage, waterMage);
                if (!waterMage.IsAlive())
                {
                    Console.WriteLine($"{waterMage.Name} has been defeated! {fireMage.Name} wins!");
                    break;
                }

                PlayerTurn(waterMage, fireMage);
                if (!fireMage.IsAlive())
                {
                    Console.WriteLine($"{fireMage.Name} has been defeated! {waterMage.Name} wins!");
                    break;
                }
            }

            Console.WriteLine("The battle is over.");
        }

        static void PlayerTurn(Mage attackingMage, Mage defendingMage)
        {
            Console.WriteLine($"\n{attackingMage.Name}'s turn!");
            Console.WriteLine("Choose a spell to cast:");
            attackingMage.DisplaySpells();

            int spellIndex = GetSpellChoice(attackingMage);
            attackingMage.Attack(defendingMage, spellIndex);
        }

        static int GetSpellChoice(Mage mage)
        {
            int choice;
            while (true)
            {
                Console.Write("Enter spell number: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= mage.Spells.Length)
                {
                    return choice - 1;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }
    }
}