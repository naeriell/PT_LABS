using System;

namespace OOP_Basics
{
    public class Linear
    {

        public double A { get; set; }
        public double B { get; set; }

        public Linear(double a, double b)
        {
            if (double.IsNaN(a))
            {
                Console.WriteLine("Поле a со значением NaN, запишите верное значение после");
            }
            else
            {
                this.A = a;
            }

            this.B = b;
        }

        public double Calculate(double x)
        {
            return A * x + B;
        }

        public void PrintEquation()
        {
            System.Console.WriteLine($"y = {A}x + {B}");
        }
    }
}