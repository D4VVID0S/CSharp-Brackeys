using System;

namespace CSharp_Brackeys_2
{
    class Character
    {
        public string name = "default";
        public string favoriteSpell = "default";
        public string favoriteAttack = "default";
        public int life;
        public int stamina;
        public int mana;
        private float experience; //removing the private/public word sets it automatically to private
        public static int count;

        // budowanie konstruktora
        public Character(string _name, string _favoriteSpell, int _life, int _stamina, int _mana)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            life = _life;
            stamina = _stamina;
            mana = _mana;
            experience = 0;

            count ++;
        }

        public void CastSpell()
        {
            if (mana > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                mana--;
                experience = experience + 3;
                Console.WriteLine("Mana: " + mana);
                Console.WriteLine("Experience: " + experience);
            }
            else
            {
                Console.WriteLine("You are out of spell slots.");
                Console.WriteLine("mana: " + mana);
            }
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots.");
            mana = mana +2;
        }
    }

    class Warrior
    {
        public string name = "default";
        public string favoriteAttack = "default";
        private int stamina;
        private float experience;
        public static int count;

        public Warrior(string _name, string _favoriteAttack)
        {
            name = _name;
            favoriteAttack = _favoriteAttack;
            stamina = 10;
            experience = 0;

            count ++;
        }

        public void SwordAttack()
        {

            if (stamina > 0)
            {
                Console.WriteLine(name + " swings his " + favoriteAttack);
                stamina = stamina - 2;
                experience = experience + 3;
                Console.WriteLine("Stamina: " + stamina);
                Console.WriteLine("Experience: " + experience);
            }
            else
            {
                Console.WriteLine("You are out of stamina!");
                Console.WriteLine("Stamina: " + stamina);
            }
        }

        public void Rest()
        {
            Console.WriteLine(name + " rests to regain stamina.");
            stamina = stamina + 4;
        }
    }

   
    class Program
    {
        static void TurnRandomizer()
        {
            Random numGen = new Random();

            for (int i = 0; i < 10; i++)
            {
                int number = numGen.Next(1, 10);
                Console.WriteLine(number);
            }
        }



        static void Main(string[] args)
        {
            TurnRandomizer();
            
            // Character wizard01 = new Wizard("Parry Hopper", "Unexpecto Patronum");
            // wizard01.CastSpell();

            // Character wizard02 = new Wizard("Glindalf Merlinson", "Abracadabra");
            // wizard02.CastSpell();

            // Character warrior01 = new Warrior("Cobra Libre", "Big Chungus of Death");
            // warrior01.SwordAttack();

            // Character warrior02 = new Warrior("Sticky Stich", "Lepiący się Język Kobry");
            // warrior02.SwordAttack();

            // Console.WriteLine("Created wizards: " + Wizard.count);
            // Console.WriteLine("Created warriors: " + Warrior.count);

            // Wait before closing
            Console.ReadKey();
        }
    }
}