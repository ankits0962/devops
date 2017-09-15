using System;
using System.Collections.Generic;
using System.Linq;

namespace CakeDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var name = args.Any() ? args[0] : "World";
            Console.WriteLine(SayHello(name));
            foreach(var i in GetNames())
            {
                Console.WriteLine(i);
            }
           
            Console.ReadKey();

        }

        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }
        public static string SayGoodBye(string name)
        {
            return $"GoodBye {name}";
        }

        public static List<string> GetNames()
        {
            List<string> names = new List<string>();
            names.Add("X");
            names.Add("Y");
            names.Add("Z");
           
            return names;
        }
    }
}
