using System;
using System.Text;


namespace ShapeLib
{
    public abstract class Shape
    {
        protected ConsoleColor _color;
        
        //a
        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }
        
        //b
        public Shape(ConsoleColor col)
        {
            _color = col;
        }

        //c
        public Shape()
        {
            _color = ConsoleColor.White;
        }

        //d
        public virtual void Display()
        {
            Console.WriteLine("Shape Color : " + _color);
        }

        //e
        public abstract double Area
        {
            get;
        }
    }


    public class Rectangle : Shape, IPersist, IComparable
    {
        //a
        public Rectangle(double width, double height, ConsoleColor col)
        : base(col)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(double width, double height)
        : base()
        {
            Width = width;
            Height = height;
        }

        //b
        public double Width { get; set; }

        public double Height { get; set; }

        //c
        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }

        //d
        public override void Display()
        {
            Console.WriteLine("Rectangle Width : " + Width + " and Rectangle Height : " + Height + " ,Rectangle Color is : " + _color);
        }

        public void Write(StringBuilder sb)
        {           
            sb.AppendLine("Rectangle Width : " + Width + ", and Rectangle Height : " + Height);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Rectangle e = obj as Rectangle;

            int result = Width.CompareTo(e.Width);
            if (result == 0)
                result = Height.CompareTo(e.Height);
            return result;
        }
    }


    public class Ellipse : Shape, IPersist,IComparable
    {
        public const double Pi = Math.PI;
        protected double _major;
        protected double _minor;

        public Ellipse(double major, double minor, ConsoleColor col)
        : base(col)
        {
            _major = major;
            _minor = minor;
        }

        public Ellipse(double major, double minor)
        : base()
        {
            _major = major;
            _minor = minor;
        }

        public virtual double Major { get; set; }
        public double Minor { get; set; }

        public override double Area
        {
            get
            {
                return _major * _minor * Pi;
            }
        }

        public override void Display()
        {
            Console.WriteLine("Ellipse Semi-major : " + _major + " and Ellipse Semi-minor : " + _minor + " ,Ellipse Color is : " + _color);
        }

        public virtual void Write(StringBuilder sb)
        {         
            sb.AppendLine("Ellipse Semi-major : " + _major + ", and Ellipse Semi-minor : " + _minor);
        }

        public virtual int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Ellipse e = obj as Ellipse;

            int result = _major.CompareTo(e._major);
            if (result == 0)
                result = _minor.CompareTo(e._minor);
            return result;
        }
    }


    public class Circle : Ellipse
    {
        public Circle(double radius,  ConsoleColor col) : base(radius, 0, col)
        {
        }

        public Circle(double radius) : base(radius, 0)
        {
        }

        public  double Radius { get { return _major; }  }

        public override double Area
        {
            get
            {
                return _major * _major * Pi;
            }
        }

        public override void Display()
        {
            Console.WriteLine("Circle Radius  : " + _major + " ,Circle Color is : " + _color);
        }

        public override void Write(StringBuilder sb)
        {         
            sb.AppendLine("Circle Radius  : " + _major);
        }

        public override int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Circle c = obj as Circle;
                return Radius.CompareTo(c.Radius);
            
        }
    }
}
