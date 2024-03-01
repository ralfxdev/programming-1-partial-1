//1.- Escribir un programa que le pida al usuario un número entero positivo y le muestre un menú con las siguientes opciones:
//Calcular el factorial del número.
//Calcular la raíz cuadrada del número.
//Salir del programa.
//El usuario debe poder elegir una opción y repetir el proceso hasta que elija salir.

int n;

do
{
    Console.WriteLine("Ingrese un número entero positivo:");
    string input = Console.ReadLine()!;

    try
    {
        n = int.Parse(input);

        if (n <= 0)
        {
            Console.WriteLine("El número ingresado no es válido.");
            continue;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato incorrecto.");
        continue;
    }
    catch (OverflowException)
    {
        Console.WriteLine("El número ingresado es demasiado grande.");
        continue;
    }

    Console.WriteLine("\nMenú:");
    Console.WriteLine("[1] Calcular el factorial del número.");
    Console.WriteLine("[2] Calcular la raíz cuadrada del número.");
    Console.WriteLine("[3] Salir.");

    int opcion;

    do
    {
        Console.WriteLine("Elije una opción:");
        string inputOption = Console.ReadLine()!;

        try
        {
            opcion = int.Parse(inputOption);

            if (opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato incorrecto.");
            continue;
        }
        catch (OverflowException)
        {
            Console.WriteLine("El número ingresado es demasiado grande.");
            continue;
        }

        switch (opcion)
        {
            case 1:
                long factorial = 1;
                for (int i = 2; i <= n; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"El factorial de {n} es: {factorial}\n");
                break;
            case 2:
                Console.WriteLine($"La raíz cuadrada de {n} es: {Math.Sqrt(n)}\n");
                break;
            case 3:
                Console.WriteLine("Saliendo del programa...\n");
                Environment.Exit(0);
                break;
        }

        break;

    } while (true);

} while (true);