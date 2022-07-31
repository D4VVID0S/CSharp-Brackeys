class Wizard
{
    public string name;
    public string favoriteSpell;
    public int spellSlots;
    public float experience;

    public void CastSpell()
    {
        Console.WriteLine(name + " casts " + favoriteSpell);
        spellSlots--;
    }
}

// Main

Wizard wizard01 = new Wizard();

wizard01.name = "Parry Hopper";
wizard01.favoriteSpell = "Unexpecto patronum";
wizard01.spellSlots = 2;
wizard01.experience = 0f;


Console.WriteLine("Spellslots: " + wizard01.spellSlots);
wizard01.CastSpell();

// Wait before closing
Console.ReadKey();