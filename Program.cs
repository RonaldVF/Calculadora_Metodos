namespace Calculadora_Metodos
{
    internal class Program
    {
        static double Sumar(double a, double b)
        {
            return a + b;
        }   

        static double Restar(double a, double b)
        {
            return a - b;
        }   

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }   

        static void Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
            else
            {
                Console.WriteLine($"División: {a / b}");
            }
        }
        static double Potencia(double @base, double exponente)
        {
            return Math.Pow(@base, exponente);
        }

        static double LeerNumero(string mensaje)
        {
            Console.Write(mensaje);

                return double.Parse(Console.ReadLine()); 
        }   
        static void Main(string[] args)
        {
          double num1 = LeerNumero("Ingrese el primer numero: ");
            double num2 = LeerNumero("Ingrese el segundo numero: ");
            Console.WriteLine();

            Console.WriteLine($"- Suma: {Sumar(num1, num2)}");
            Console.WriteLine();
            Console.WriteLine($"- Resta: {Restar(num1, num2)}");
            Console.WriteLine();
            Console.WriteLine($"- Multiplicación: {Multiplicar(num1, num2)}");
            Console.WriteLine();
            Dividir(num1, num2);
            Console.WriteLine();
            Console.WriteLine($"- Potencia: {Potencia(num1, num2)}");

        }
    }
}
