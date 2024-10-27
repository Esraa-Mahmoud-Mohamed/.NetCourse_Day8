using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Geoshape
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

        public Geoshape()
        {
            dim1 = dim2 = 0;
        }
        public Geoshape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }
    }

    public class Rect : Geoshape
    {
        public Rect() 
        {
            Console.WriteLine("Rect df ctor");
        }

        public Rect(double _dim1, double _dim2):base(_dim1, _dim2)
        {
            Console.WriteLine("Rect param ctor");
        }

        public double Area()
        {
            return Dim1 * Dim2;
        }
    }

    public class Square:Geoshape
    {
        public Square()
        {
            
        }
        public Square(double _dim):base(_dim, _dim)
        {
            
        }
    }

    public class Tri : Geoshape
    {
        public Tri()
        {
            
        }
        public Tri(double _base, double _height):base(_base, _height)
        {
            
        }

        public double Area()
        {
            return 0.5 * Dim1 * Dim2;   
        }
    }

    public class Circle:Geoshape
    {
        public Circle()
        {
            
        }
        public Circle(double _radius):base(_radius, _radius)
        {
            
        }
        public double Area()
        {
            return Math.PI * Dim1 * Dim2;
        }
    }
}
