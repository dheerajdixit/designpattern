using DP.Singleton;
using System;
namespace DesignPatterns
{
    class Prgoram
    {
        public static void Main()
        {
            //Singleton b;
            var b = Singleton.Add2Plus2;
            var c = Singleton.Instance;
           
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}