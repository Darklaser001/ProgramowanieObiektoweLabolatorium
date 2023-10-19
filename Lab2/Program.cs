using Lab2.Constructions;
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var construction = new Construction(12, 34, 5, 6, "Stone");

            Console.WriteLine(construction.BuildMaterial);
        }
    }
}
