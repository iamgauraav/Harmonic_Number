using System;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            double sum = 0.0;

            for ( double count = 1; count <= num; count++)
            {
                Console.WriteLine("1/{0} +",count);

                sum = sum + 1 / count;
            }
            Console.WriteLine("the sum of seies {0} is {1} ",num,sum);
        }
    }
}
