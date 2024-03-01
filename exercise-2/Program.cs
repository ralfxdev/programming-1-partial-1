//2.- Escribir un programa que solicite al usuario dos números enteros y un operador matemático (+, -, *, /).
//El programa debe realizar la operación indicada y mostrar el resultado,
//validando que los datos sean correctos y el operador sea válido.

int n1, n2;
char operador;

Dictionary<char, Func<int, int, double>> operaciones = new Dictionary<char, Func<int, int, double>>
{
    {'+', (a, b) => a + b },
    {'-', (a, b) => a - b },
    {'*', (a, b) => a * b },
    {'/', (a, b) => a / (double)b }
};

while (true)
{
    try
    {
        Console.WriteLine("Ingrese el primer número:");
        n1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingrese el segundo número:");
        n2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("\nIngrese el operador matemático:");
        Console.WriteLine("[+] Suma.");
        Console.WriteLine("[-] Resta.");
        Console.WriteLine("[*] Multiplicación.");
        Console.WriteLine("[/] División.");
        operador = char.Parse(Console.ReadLine()!);

        if (!operaciones.ContainsKey(operador))
        {
            Console.WriteLine("Operador inválido.");
            continue;
        }

        if (operador == '/' && n2 == 0)
        {
            Console.WriteLine("Error: división por cero.");
            continue;
        }

        double resultado = operaciones[operador](n1, n2);
        Console.WriteLine($"El resultado de {n1} {operador} {n2} es: {resultado}");
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato incorrecto.");
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