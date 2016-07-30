using System;
using System.Text;
using ShapeLib;
using System.Collections;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            ShapeManager shapeManager = new ShapeManager();
            shapeManager.Add(new Rectangle(5, 3));
            shapeManager.Add(new Circle(2, ConsoleColor.Black));
            shapeManager.Add(new Ellipse(4,6,ConsoleColor.Cyan));
            shapeManager.Add(new Rectangle(5,3));
            shapeManager.Add(new Ellipse(2,5));
            shapeManager.Add(new Rectangle(4,3,ConsoleColor.Blue));
            shapeManager.Add(new Circle(5));
            shapeManager.Add(new Ellipse(2, 5, ConsoleColor.Cyan));
            shapeManager.DisplayAll();
            Console.WriteLine();
            shapeManager.Save(sb);
            Console.WriteLine(sb.ToString());
            Console.WriteLine();
            Rectangle r = new Rectangle(5, 1);
            Rectangle r1 = new Rectangle(5, 2, ConsoleColor.Blue);
            Console.WriteLine(r.CompareTo(r1));
            Circle c1 = new Circle(7, ConsoleColor.Black);
            Circle c2 = new Circle(8);
            Console.WriteLine(c1.CompareTo(c2));
        }
    }
}
