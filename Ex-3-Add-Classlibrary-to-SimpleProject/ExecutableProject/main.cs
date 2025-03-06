using System;
using ClassLib;

namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetInput.GetName();
            Console.WriteLine("Hello, " + name + "!");
            // Console.WriteLine("LoL");
        }
    }
}