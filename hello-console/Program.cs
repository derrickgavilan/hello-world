using hello_console.Countries;

namespace hello_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            France france = new France();
            Console.WriteLine(france.Message);

            Spain spain = new Spain();
            Console.WriteLine(spain.Message);
        }
    }
}
