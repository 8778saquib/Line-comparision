using System;
namespace linecompprob
{
    public class linecomp
    {
        public void calculatinglinelength()
        {
            double lengthline;
            Console.Write("Enter the point X1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point X2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point Y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point Y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            lengthline = Math.Sqrt(length);
            Console.WriteLine("length of line is {0}", lengthline);

        }

    }
}
