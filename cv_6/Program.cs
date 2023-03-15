using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cv_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GrObject[] fieldObjects = new GrObject[8];

            fieldObjects[0] = new Circle(5);
            fieldObjects[1] = new Rectangle(5,3);
            fieldObjects[2] = new Ellipse(3,2);
            fieldObjects[3] = new Triangle(5, 3);
            fieldObjects[4] = new Block(5,3,8);
            fieldObjects[5] = new Cylinder(5,8);
            fieldObjects[6] = new Sphere(5);
            fieldObjects[7] = new Pyramid(5, 6, 7);

            double totalArea = 0;
            double totalSurface = 0;
            double totalVolume = 0;

            for(int i = 0; i < fieldObjects.Length; i++)
            {
                if(fieldObjects[i] is Object2D object2D)
                {
                    totalArea += object2D.CountArea();
                }
                if(fieldObjects[i] is Object3D object3D)
                {
                    totalSurface += object3D.CountSurface();
                    totalVolume += object3D.CountVolume();
                }
                fieldObjects[i].Draw();
            }

            Console.WriteLine($"\nTotal area is: {totalArea:N3}");
            Console.WriteLine($"Total surface is: {totalSurface:N3}");
            Console.WriteLine($"Total volume is: {totalVolume:N3}");
        }
    }
}