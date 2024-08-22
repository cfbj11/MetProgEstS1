namespace NumeroParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Programa que determina si un numero es par o impar.");
            Console.Write("\nIngrese un numero: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"\n{num} es par.");
            }
            else
            {
                Console.WriteLine($"\n{num} es impar.");
            }
        }
    }
}
