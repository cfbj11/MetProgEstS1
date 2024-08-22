namespace AumentarSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, cargo;
            double salario, aumento, nsalario;
            Console.WriteLine("Programa que calcula el aumento de salario de un trabajador.");
            Console.Write("\nNombre: ");
            nombre = Console.ReadLine();
            Console.Write("Cargo: ");
            cargo = Console.ReadLine();
            Console.Write("Salario: ");
            salario = double.Parse(Console.ReadLine());
            aumento = salario * 0.10;
            nsalario = salario * 1.10;
            Console.WriteLine($"\nNombre: {nombre} / Cargo: {cargo}");
            Console.WriteLine($"Salario: {salario} / Aumento: {aumento} / Nuevo Salario: {nsalario}");
        }
    }
}
