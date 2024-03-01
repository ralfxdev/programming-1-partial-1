//3.- Escribir un programa que imprima una tabla de multiplicar
//del 1 al 10 para un número introducido por el usuario.

int n;

while (true)
{
    try
    {
        Console.WriteLine("Ingrese un número para generar la tabla de multiplicar:");
        if (!int.TryParse(Console.ReadLine(), out n))
        {
            throw new FormatException("Error: Debe ingresar un número válido.");
        }

        Console.WriteLine($"Tabla de multiplicar del {n}:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($@"       {n} x {i} = {n * i}");
        }

        break;
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