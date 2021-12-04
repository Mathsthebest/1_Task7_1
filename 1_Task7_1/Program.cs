using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double S1 = CalcArea(a, b, c);
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            double S2 = CalcArea(d, e, f);

            if (S1>S2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
                Console.ReadKey();
            }
            else
            {
                if (S1 == S2)
                {
                    Console.WriteLine("Площади треугольников равны");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Площадь второго треугольника больше");
                    Console.ReadKey();
                }
            }


        }
        static double CalcArea(double a, double b, double c)
        {
            double Per, PoluPer,S;
            Per = a + b + c;
            PoluPer = Per / 2;
            S = Math.Sqrt(PoluPer * (PoluPer - a) * (PoluPer - b) * (PoluPer - c));
            return S;
        }
    }
}
