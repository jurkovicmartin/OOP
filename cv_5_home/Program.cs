using cv_5_home;
using System;

namespace cv_5_home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Truck dodavka = new Truck(Car.FuelType.Oil, 35, 10);

            Console.WriteLine(dodavka);
        }
    }
}