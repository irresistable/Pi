using System;

namespace Pi
{
    class Program
    {
        static void Main(string[] args)
        {
            int InCirclePointsAmount = 0;
            int TotalAmountOfPoints=0;
            double p = 0;

            Console.WriteLine("Enter amount");
            int amount = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < amount+1; i++)
            {

                double x = RandomDouble();
                double y = RandomDouble();
                double z = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
                TotalAmountOfPoints++;
                if (z < 1)
                {
                    InCirclePointsAmount++;
                }
                p = (double)InCirclePointsAmount * 4 / TotalAmountOfPoints;
                Console.Write($"N{i}-{x} {y} {InCirclePointsAmount} {TotalAmountOfPoints} Pi is {p}\n");
            }
            Console.WriteLine($"Pi is {p}");
            Console.ReadLine();
        }
        static double RandomDouble()
            {
            var rnd = new Random();
            double random = Math.Round(rnd.NextDouble(), 3);
            return random;
        }

    }
   
}
