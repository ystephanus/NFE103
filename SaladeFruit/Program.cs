using System;
using System.Collections.Generic;

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            SaladeFruit saladeFruitEte =  FactorySalade.create("ete");
            foreach (Fruit f in saladeFruitEte.saladefruit)
            {
                Console.WriteLine(f);
            }
            SaladeFruit saladeFruitHiver = FactorySalade.create("hiver");
            foreach (Fruit f in saladeFruitHiver.saladefruit)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
    }
}
