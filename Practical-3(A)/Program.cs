using System;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num, deno;

            Console.WriteLine("Enter Numerator : ");
            //   num = int.Parse(Console.ReadLine());
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Denominator : ");
            deno = Convert.ToInt32(Console.ReadLine());

            int quotient = num / deno;
            int remainder = num % deno;

            Console.WriteLine($"Integer division result : {quotient} with a remainder : {remainder}");

            double frac_quotient = Math.Round((double)num / deno);

            Console.WriteLine($"Fractional Quotient : {frac_quotient}");
            Console.WriteLine($"Floating Point Division Result : {(float)num/deno}");
            Console.WriteLine($"Mixed Fraction : {quotient} {remainder}/{deno}");
        }
    }
}

