using System.Runtime.CompilerServices;

namespace TheVeryLastDayBeforeBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadLine();
            
        }

        static async void Start()
        {

            ServerConnection server = new();
            Console.WriteLine(await server.PostWeatherType("Thunder", 5.7, "A lot of rain with occasional thunder."));
        }
    }
}
