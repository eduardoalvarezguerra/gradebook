using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string strCadena = "";
            if (args.Length > 0)
                // {
                //     //Console.WriteLine($"Hello, {args[0]}!", $" Y también Hello, {args[1]}!");
                //     Console.WriteLine("Hello, {0} y {1} y {2}", args[0], args[1], args[2]);
                // }
                // else
                // {
                //     Console.WriteLine($"Hello, Vacío!");
                // }  
            //strCadena = (args.Length > 0) ? "Hello, " + args[0] + " " + args[1] + " " + args[2] : "Hello, Vacío!";
            Console.WriteLine((args.Length > 0) ? "Hello, " + args[0] + " " + args[1] + " " + args[2] : "Hello, Vacío!");
        }

    }
}
