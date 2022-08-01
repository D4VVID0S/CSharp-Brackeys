using System;

namespace CSharp_Brackeys_2
{
    class Wizard
    {
        public string name = "default";
        public string favoriteSpell = "default";
        private int spellSlots;
        private float experience; //removing the private/public word sets it automatically to provate

        public static int Count;

        // budowanie konstruktora
        public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            experience = 0;

            Count ++;
        }

        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellSlots--;
                experience = experience + 3;
            }
            else
            {
                Console.WriteLine("You are out of spell slots.");
                Console.WriteLine("Spellslots: " + spellSlots);
            }
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots.");
            spellSlots = 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Parry Hopper", "Unexpecto Patronum");
            wizard01.CastSpell();

            Wizard wizard02 = new Wizard("Glindalf Merlinson", "Abracadabra");
            wizard02.CastSpell();

            Console.WriteLine("Created wizards: " + Wizard.Count);

            // Wait before closing
            Console.ReadKey();
        }
    }
}