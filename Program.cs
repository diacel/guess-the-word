string input;

while (true)
{
    Console.WriteLine("[RU] Что бы программа закрылась нужно написать волшебное слово(на английском): ");
    Console.WriteLine("[EN] To close the program you need to write a magic word (in English): ");
    input = Console.ReadLine();

    if (input.ToLower() == "abracadabra")
    {
        Console.WriteLine("[RU] Верно " + input + " было волшебным словом");
        Console.WriteLine("[EN] Right " + input + " was the magic word");
        break;
    }
    else
    {
        Console.WriteLine("[RU] Это не волшебное слово подумай лучше.");
        Console.WriteLine("[EN] It's not a magic word think better.");
        Console.WriteLine("...");
        Console.WriteLine("...");
        Console.WriteLine("...");
    }
}