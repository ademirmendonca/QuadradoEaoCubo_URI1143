using System;

namespace QuadradoEaoCubo_URI1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double totalQuadrado =  Math.Pow(i, + 2);
                double totalCubo = Math.Pow(i, + 3);
                Console.WriteLine(i + " " + totalQuadrado + " " + totalCubo);                
            }
        }
    }
}
