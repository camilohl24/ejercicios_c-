int a, b, c;
bool IsValid;
var answer = string.Empty;
do

{
    Console.WriteLine("Programa para identificar cual numero es mayor.");
    Console.WriteLine("si quieres continuar presiona c o si no prersiona s");
    answer = Console.ReadLine();
    if (answer.ToLower() == "c")
    {
        do
        {
            Console.WriteLine(" ingrese el primer numero:");

            IsValid = int.TryParse(Console.ReadLine(), out a);
            if (!IsValid)
            {
                Console.WriteLine($"el numero {a}, no es un numero permitido debe ser un numero entero o presiona s para salir");
            }

        }
        while (!IsValid);
        do
        {
            Console.WriteLine(" ingrese el segundo numero:");
            IsValid = int.TryParse(Console.ReadLine(), out b);
            if (!IsValid)
            {
                Console.WriteLine($"el numero {b}, no es un numero permitido debe ser un numero entero");
            }

        }
        while (!IsValid);
        do
        {
            Console.WriteLine(" ingrese el tercer  numero:");
            IsValid = int.TryParse(Console.ReadLine(), out c);
            if (!IsValid)
            {
                Console.WriteLine($"el numero {c}, no es un numero permitido debe ser un numero entero");
            }

        }
        while (!IsValid);


        if (a > b && a > c)
        {
            Console.WriteLine($"el numero mayor es {a}");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine($"el numero mayor es {b}");
        }
        else
        {
            Console.WriteLine($"el numero mayor es {c}");
        }
    }

} while (answer.ToLower() != "s");

Console.WriteLine("game over");


