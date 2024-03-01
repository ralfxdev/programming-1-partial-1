//Escribir un programa que adivine un número secreto entre 1 y 100.
//El usuario debe ir introduciendo números y el programa le indicará
//si el número secreto es mayor o menor que el introducido. El programa
//debe terminar cuando el usuario adivine el número secreto.

Random random = new Random();
int nSecret = random.Next(1, 101);
int attempts = 0;

Console.WriteLine("¡Shshsh es hora de adivinar el número secreto c:!");

while (true)
{
    try
    {
        Console.WriteLine("Introduce un número entre 1 y 100:");
        if (!int.TryParse(Console.ReadLine(), out int nUser) || nUser < 1 || nUser > 100)
        {
            throw new FormatException("Introduce un número válido entre 1 y 100.");
        }

        attempts++;

        if (nUser < nSecret)
        {
            Console.WriteLine("El número secreto es mayor.");
        }
        else if (nUser > nSecret)
        {
            Console.WriteLine("El número secreto es menor.");
        }
        else
        {
            Console.WriteLine($"¡Lograste adivinar el número secreto {nSecret} en {attempts} intentos!");
            break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (OverflowException)
    {
        Console.WriteLine("El número ingresado es demasiado grande.");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Se produjo un error: {e.Message}");
    }
}