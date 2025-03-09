namespace KattisApps;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> modulos = new HashSet<int>();
        for (int i = 0; i < 10; i++)
        {
            int nums = int.Parse(Console.ReadLine());
            int modulo = nums % 42;
            modulos.Add(modulo);
        }
        Console.WriteLine(modulos.Count());
    }
}
