using Shared;

do
{
    Console.WriteLine("Ingrese 3 números diferentes");
    var a = ConsoleExtension.GetInt("Ingrese primer número : ");

    var b = ConsoleExtension.GetInt("Ingrese segundo número: ");
    if (a == b)
    {
        Console.WriteLine("deben ser numeros diferentes vuelva a empezar...");
        continue;
    }
    var c = ConsoleExtension.GetInt("Ingrese tercer número : ");
    if(b == c || c == a)
    {
        Console.WriteLine("deben ser numeros diferentes vuelva a empezar...");
        continue;
    }

    if (a > b && a > c)
    {
        if(b > c)
        {
            Console.WriteLine($"El mayor es {a}, El del medio es {b} y el menor {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {a}, El del medio es {c} y el menor {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El mayor es {b}, El del medio es {a} y el menor {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {b}, El del medio es {c} y el menor {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El mayor es {c}, El del medio es {a} y el menor {b}");
        }
        else
        {
            Console.WriteLine($"El mayor es {c}, El del medio es {b} y el menor {a}");
        }
    }
   
    
} while(true);

