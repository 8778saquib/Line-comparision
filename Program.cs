using System;

namespace linecompprob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison problem");
            linecomp lin = new linecomp();
            lin.calculatinglinelength();
            lin.compequal();
            lin.comparisons();
        }
    }
}
