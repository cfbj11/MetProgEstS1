namespace MayorTresNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Programa que determina el mayor de tres numeros.");
            Console.Write("\nN°1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("N°2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("N°3: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("\nEl primer numero es el mayor.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("\nEl segundo numero es el mayor.");
            }
            else
            {
                Console.WriteLine("\nEl tercer numero es el mayor.");
            }
        }
    }
}
