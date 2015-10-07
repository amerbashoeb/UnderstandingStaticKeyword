using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingStaticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            float area1 = Circle.CalculateArea(1);
            Console.WriteLine("Area = {0}", area1);

            float area2 = Circle.CalculateArea(1);
            Console.WriteLine("Area = {0}", area2);
        }
    }


    public static class Circle
    {
        static float _Pi = 3.141F;
        public static int _radius;

        static Circle()
        {
            _radius = 2;
        }

        public static float CalculateArea(int radius)
        {
            return Circle._Pi * radius * radius;
        }
    }
}
