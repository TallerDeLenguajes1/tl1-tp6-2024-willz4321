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
        
        //ejercicio 4

        Console.WriteLine("Ingrese una cadena de texto:");
        string inputEj4 = Console.ReadLine();

        // Obtener la longitud de la cadena
        Console.WriteLine($"Longitud de la cadena: {inputEj4.Length}");

        // Concatenar con otra cadena
        Console.WriteLine("Ingrese otra cadena de texto:");
        string inputEj4_2 = Console.ReadLine();
        string concatenada = String.Concat(inputEj4, inputEj4_2);
        Console.WriteLine($"Cadenas concatenadas: {concatenada}");

        // Extraer una subcadena
        if (inputEj4.Length >= 2)
        {
            string subcadena = inputEj4.Substring(0, 2);
            Console.WriteLine($"Subcadena: {subcadena}");
        }

        // Realizar operaciones con la calculadora
        Console.WriteLine("Ingrese el primer número para la suma:");
        string num1Str = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo número para la suma:");
        string num2Str = Console.ReadLine();

        if (double.TryParse(num1Str, out double numE1) && double.TryParse(num2Str, out double numE2))
        {
            double resultado = numE1 + numE2;
            Console.WriteLine($"La suma de {numE1} y {numE2} es igual a: {resultado}");
        }
        else
        {
            Console.WriteLine("Uno o ambos textos ingresados no son números válidos.");
        }

        // Recorrer la cadena con un ciclo foreach
        foreach (char c in inputEj4)
        {
            Console.WriteLine(c);
        }

        // Buscar la ocurrencia de una palabra
        Console.WriteLine("Ingrese una palabra para buscar en la cadena:");
        string palabra = Console.ReadLine();
        int indice = inputEj4.IndexOf(palabra);
        if (indice >= 0)
        {
            Console.WriteLine($"La palabra '{palabra}' se encontró en el índice {indice}.");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabra}' no se encontró en la cadena.");
        }

        // Convertir a mayúsculas y minúsculas
        Console.WriteLine($"Cadena en mayúsculas: {inputEj4.ToUpper()}");
        Console.WriteLine($"Cadena en minúsculas: {inputEj4.ToLower()}");

        // Dividir la cadena
        Console.WriteLine("Ingrese un carácter para dividir la cadena:");
        string divisor = Console.ReadLine();
        string[] partes = inputEj4.Split(divisor);
        Console.WriteLine("Partes de la cadena:");
        foreach (string parte in partes)
        {
            Console.WriteLine(parte);
        }

        // Resolver una ecuación simple
        Console.WriteLine("Ingrese una ecuación simple (por ejemplo, '582+2'):");
        string ecuacion = Console.ReadLine();
        string[] numeros = ecuacion.Split('+');
        if (numeros.Length == 2 && double.TryParse(numeros[0], out double numA) && double.TryParse(numeros[1], out double numB))
        {
            double res = numA + numB;
            Console.WriteLine($"El resultado de la ecuación es: {res}");
        }
        else
        {
            Console.WriteLine("La ecuación ingresada no es válida.");
        }
    }

    static string ReverseNumber(int number)
    {
        char[] numberArray = number.ToString().ToCharArray();
        Array.Reverse(numberArray);
        return new string(numberArray);
    }
}
