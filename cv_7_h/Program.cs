using System;
using System.Drawing;

namespace cv_7_home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 3, 5, 7, 9 };
            string[] strings = { "one", "two", "four", "twelve" };
            Circle[] circles = { new Circle(5), new Circle(3), new Circle(8) };
            Rectangle[] rectangles = { new Rectangle(5, 3), new Rectangle(8, 4), new Rectangle(1, 2) };
            Ellipse[] ellipses = { new Ellipse(5, 3), new Ellipse(2, 2), new Ellipse(3, 5) };
            Triangle[] triangles = {new Triangle(5, 3), new Triangle(6, 2),new Triangle(4, 7) };
            Square[] squares = { new Square(5), new Square(3), new Square(8),new Square(1) };
            Object2D[] objects = { new Circle(3), new Square(5), new Triangle(5, 2) };

            Console.WriteLine($"Biggest int is: {Extrems.Biggest(ints)}");
            Console.WriteLine($"Smallest int is: {Extrems.Smallest(ints)}");
            Console.WriteLine($"Biggest string is: {Extrems.Biggest(strings)}");
            Console.WriteLine($"Smallest string is: {Extrems.Smallest(strings)}");
            Console.WriteLine($"Biggest cirlce is: {Extrems.Biggest(circles)}");
            Console.WriteLine($"Smallest circle is: {Extrems.Smallest(circles)}");
            Console.WriteLine($"Biggest rectangle is: {Extrems.Biggest(rectangles)}");
            Console.WriteLine($"Smallest rectangle is: {Extrems.Smallest(rectangles)}");
            Console.WriteLine($"Biggest ellipse is: {Extrems.Biggest(ellipses)}");
            Console.WriteLine($"Smallest ellipse is: {Extrems.Smallest(ellipses)}");
            Console.WriteLine($"Biggest triangle is: {Extrems.Biggest(triangles)}");
            Console.WriteLine($"Smallest triangle is: {Extrems.Smallest(triangles)}");
            Console.WriteLine($"Biggest square is: {Extrems.Biggest(squares)}");
            Console.WriteLine($"Smallest square is: {Extrems.Smallest(squares)}");
            Console.WriteLine($"Biggest object is: {Extrems.Biggest(objects)}");
            Console.WriteLine($"Smallest object is: {Extrems.Smallest(objects)}");


            var filtered = ints.Where(value => value > 4 && value < 8);

            Console.Write("\nLinq filter result: ");
            foreach (int item in filtered)
            {
                Console.Write(item + ",");
            }
        }
    }
}