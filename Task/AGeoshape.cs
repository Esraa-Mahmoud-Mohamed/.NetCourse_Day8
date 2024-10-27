using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public abstract class AGeoshape
    {
        double dim1;
        double dim2;

        public double Dim1
        {
            get
            {
                return dim1;
            }

            set
            {
                dim1 = value;
            }
        }

        public double Dim2
        {
            get
            {
                return dim2;
            }

            set
            {
                dim2 = value;
            }
        }

        public AGeoshape()
        {
            dim1 = dim2 = 0;
        }
        public AGeoshape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }
    }

    public class Rect2 : AGeoshape
    {
        public Rect2()
        {
            Console.WriteLine("Rect df ctor");
        }

        public Rect2(double _dim1, double _dim2) : base(_dim1, _dim2)
        {
            Console.WriteLine("Rect param ctor");
        }

        public double Area()
        {
            return Dim1 * Dim2;
        }
    }

    public class Square2 : AGeoshape
    {
        public Square2()
        {

        }
        public Square2(double _dim) : base(_dim, _dim)
        {

        }
    }

    public class Tri2 : AGeoshape
    {
        public Tri2()
        {

        }
        public Tri2(double _base, double _height) : base(_base, _height)
        {

        }

        public double Area()
        {
            return 0.5 * Dim1 * Dim2;
        }
    }

    public class Circle2 : AGeoshape
    {
        public Circle2()
        {

        }
        public Circle2(double _radius) : base(_radius, _radius)
        {

        }
        public double Area()
        {
            return Math.PI * Dim1 * Dim2;
        }
    }
}
