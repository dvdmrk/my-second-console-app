using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            while (true)
            {
                counter++;
                Console.WriteLine($"Counter: {counter}");
                System.Threading.Tasks.Task.Delay(1000).Wait();
            }        
        }
    }
}
