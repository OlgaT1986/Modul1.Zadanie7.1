using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, x1, y1, z1;
            Console.WriteLine("Параметры первого треугольника");
            Console.Write("Введите длину стороны x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны y = ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны z = ");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Параметры второго треугольника");
            Console.Write("Введите длину стороны x = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны y = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны z = ");
            z1 = Convert.ToDouble(Console.ReadLine());
            if (Treyg(x, y, z) > Treyg(x1, y1, z1))
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if (Treyg(x, y, z) < Treyg(x1, y1, z1))
                Console.WriteLine("Площадь второго треугольника больше");
            else Console.WriteLine("Площади равны");

            Console.ReadKey();
        }
        static double Treyg(double a, double b, double c)
        {
            double p;
            p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}

