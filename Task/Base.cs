﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Base
    {
        protected int x;
        protected int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public Base()
        {
            x = y = 0;
        }
        public Base(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public virtual void Show()
        {
            Console.WriteLine("I'm Base");
        }
    }
    ///
    public class Derived : Base
    {
        protected int z;
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public Derived()
        {
            x = y = z = 0;
        }
        public Derived(int _x, int _y, int _z) : base(_x, _y)
        {
            z = _z;
        }
        public override void Show()
        {
            Console.WriteLine("I'm Derived");
        }
    }

    public class Derived2 : Derived
    {
        protected int a;
        public Derived2()
        {
            a = 0;
        }
        public Derived2(int _x, int _y, int _z, int _a) : base(_x, _y, _z)
        {
            a = _a;
        }
        public override void Show()
        {
            Console.WriteLine("I'm Derived2");
        }
    }
}
