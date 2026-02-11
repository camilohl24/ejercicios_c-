using Shared;

do
{
    Console.WriteLine("Ingrese 2 números diferentes");
    var a = ConsoleExtension.GetInt("Ingrese primer número : ");

    var b = ConsoleExtension.GetInt("Ingrese segundo número: ");

    if (b % a == 0)
    {
        Console.WriteLine($"{a}  Es multiplo de {b}");
    }
    else

    {
        Console.WriteLine($"{a} No  es multiplo de {b}");
    }

} while (true);


