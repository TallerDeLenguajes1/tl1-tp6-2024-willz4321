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

        //EJERCICIO 2 B

         Console.WriteLine("Ingrese un número:");
        string inputText = Console.ReadLine();

        if (double.TryParse(inputText, out double n))
        {
            Console.WriteLine($"Valor absoluto: {Math.Abs(n)}");
            Console.WriteLine($"Cuadrado: {Math.Pow(n, 2)}");
            Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(n)}");
            Console.WriteLine($"Seno: {Math.Sin(n)}");
            Console.WriteLine($"Coseno: {Math.Cos(n)}");
            Console.WriteLine($"Parte entera: {Math.Truncate(n)}");

            Console.WriteLine("Ingrese el primer número de la comparación:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo número de la comparación:");
            string input2 = Console.ReadLine();

            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                Console.WriteLine($"Máximo: {Math.Max(number1, number2)}");
                Console.WriteLine($"Mínimo: {Math.Min(number1, number2)}");
            }
            else
            {
                Console.WriteLine("Uno o ambos textos ingresados no son números válidos.");
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
