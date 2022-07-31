PrintNumber();

void PrintNumber()
{
    Random numGen = new Random();
    int number = numGen.Next(1, 10);
    Console.WriteLine(number);
}

// Wait before closing
Console.ReadKey();