namespace SumaDosNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, suma;
            Console.WriteLine("Programa que calcula la suma de dos numeros.");
            Console.Write("\nIngrese un numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            num2 = double.Parse(Console.ReadLine());
            suma = num1 + num2;
            Console.WriteLine($"\nEl resultado de la suma es: {suma}");
        }
    }
}
