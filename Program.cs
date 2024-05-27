using System;

class Program
{
    static void Main()
    {

        //EJERCICIO 1
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

        //EJERCICIO 2 A
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el primer número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    continue;
            }

            Console.WriteLine($"El resultado es: {resultado}");

            Console.WriteLine("¿Desea realizar otro cálculo? (s/n)");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() != "s")
            {
                continuar = false;
            }
        }

        //EJERCICIO B
    }

    static string ReverseNumber(int number)
    {
        char[] numberArray = number.ToString().ToCharArray();
        Array.Reverse(numberArray);
        return new string(numberArray);
    }
}
