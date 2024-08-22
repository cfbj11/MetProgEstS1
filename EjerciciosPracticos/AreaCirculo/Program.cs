namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio,area;
            Console.WriteLine("Programa que calcula el area de un circulo.");
            Console.Write("\nProporciona el radio del circulo: ");
            radio = double.Parse(Console.ReadLine());
            area = Math.PI * Math.Pow(radio,2);
            Console.WriteLine($"\nEl area del circulo es: {area}");
        }
    }
}
