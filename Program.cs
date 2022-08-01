using System;

namespace CSharp_Brackeys_2
{
    class Wizard
    {
        public string name = "default";
        public string favoriteSpell = "default";
        public int spellSlots;
        public float experience;

        public void CastSpell()
        {
            Console.WriteLine(name + " casts " + favoriteSpell);
            spellSlots--;
            Console.WriteLine("Spellslots: " + spellSlots);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard();

            wizard01.name = "Parry Hotter";
            wizard01.favoriteSpell = "Unexpecto Patronum";
            wizard01.spellSlots = 2;
            wizard01.experience = 0f;


            Console.WriteLine("Spellslots: " + wizard01.spellSlots);
            wizard01.CastSpell();

            // Wait before closing
            Console.ReadKey();
        }
    }
}