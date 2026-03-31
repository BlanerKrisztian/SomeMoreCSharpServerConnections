using System.Runtime.CompilerServices;

namespace TheVeryLastDayBeforeBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start();
            Start2();
            Console.ReadLine();
            
        }

        static async void Start()
        {

            ServerConnection server = new();
            Console.WriteLine(await server.PostWeatherType("Thunder", 5.7, "A lot of rain with occasional thunder."));
        }
        static async void Start2()
        {
            ServerConnection server = new();
            (await server.GetFishes()).ForEach(f => Console.WriteLine(f));

            Console.WriteLine("give fish name");
            string fishname = Console.ReadLine();
            Console.WriteLine("weight aswell");
            double weight = double.Parse(Console.ReadLine());
            // await server.PostFish(fishname,weight);
        }
    }
}
