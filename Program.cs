using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, ingrese un numero:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number > 0)
            {
                string reversedNumber = ReverseNumber(number);
                Console.WriteLine($"El número invertido es: {reversedNumber}");
            }
            else
            {
                Console.WriteLine("El número ingresado no es mayor a 0. No se puede invertir.");
            }
        }
        else
        {
            Console.WriteLine("El texto ingresado no es un número válido.");
        }
    }

    static string ReverseNumber(int number)
    {
        char[] numberArray = number.ToString().ToCharArray();
        Array.Reverse(numberArray);
        return new string(numberArray);
    }
}
