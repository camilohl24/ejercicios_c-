using Shared;

do
{
    Console.WriteLine("Programa para verificar si un año es o fue biciesto");
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = ConsoleExtension.GetInt("Ingrese año: ");
    if (year == currentYear)
    {
        message = "es";
    }
    else if (year > currentYear)
    {
        message = " va a ser";
    }
    else
    {
        message = "fue";
    }

    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} Si {message} biciesto");
            }
            else
            {
                Console.WriteLine($"{year} No {message} biciesto");
            }
        }
        else
        {
            Console.WriteLine($"{year} Si {message} biciesto");
        }
    }
    else
    {
        Console.WriteLine($"{year} No {message} biciesto");
    }

  
} while (true);
