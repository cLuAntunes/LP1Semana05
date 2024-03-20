using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice = int.Parse(args[0]);
            int seed = int.Parse(args[1]);

            Random rand = new Random(seed);

            int sum = 0;
            
            for (int i = 0; i < dice; i++)
            {
                int roll = rand.Next(1, 7);
                sum += roll;
            }

            Console.WriteLine(sum);
        }
    }
}
