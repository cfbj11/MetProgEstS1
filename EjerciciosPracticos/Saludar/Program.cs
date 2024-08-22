namespace Saludar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Ingresa tu nombre.");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine($"\nHola {nombre}!");
        }
    }
}
