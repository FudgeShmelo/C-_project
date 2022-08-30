
namespace drawingApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Drawing;
    [Serializable]

    public abstract class ribb
    {
        // privates:
       
        private int size;
        private float x;
        private float y;

        // get's and set's:

        public int Size  // property
        {
            get { return size; }   // get method
            set { size = value; }  // set method
        }

        public float X  // property
        {
            get { return x; }   // get method
            set { x = value; }  // set method
        }

        public float Y // property
        {
            get { return y; }   // get method
            set { y = value; }  // set method
        }

        // Abstract methods:

        public abstract void Draw(Graphics g);
        //public abstract bool inRange(int x, int y);
    }

    [Serializable]
    class  myCircle: ribb
    {
        float radius;

        public myCircle()
         : this(5 , 5 , 5) { }

        public myCircle(float rad ,float xp , float yp )
        {
            radius = rad;
            X = xp;
            Y = yp;
            Size = 1; // how much tszlaot in shape
        }

        public float Radius // property
        {
            get { return radius; }   // get method
            set { radius = value; }  // set method
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Aqua, 4);
            g.DrawEllipse(pen, X - radius, Y - radius, radius * 2, radius * 2);
        }

      
    }

    [Serializable]
    class equalRibbedTriangle:ribb
    {
        // Privates:

        float height;

        // Constructors:

        public equalRibbedTriangle()
            : this(10) { }

        public equalRibbedTriangle(float height)
        {
            this.height = height;
            X = 2;
            Y = 2;
            Size = 3;
        }

        // float height get and set:

        public float Height
        {
            get { return height; }
            set { height = value; } 
        }

        // Draw overriding:

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Aqua, 4);
            g.DrawLine(pen, X, Y, X + height, Y + height);
            g.DrawLine(pen, X + height, Y + height, X, Y + height * 2);
            g.DrawLine(pen, X, Y + height * 2, X, Y);
        }
    }


    [Serializable]
    class square : ribb
    {
        // Privates:

        float height;

        // Constructors:

        public square()
            : this(10) { }

        public square(float height)
        {
            this.height = height;
            X = 5;
            Y = 5; 
            Size = 4;
        }

        // height get and set:

        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        // Draw overriding:

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Aqua, 4);
            g.DrawRectangle(pen, X, Y, height, height);
        }
    }

    [Serializable]
    class rectangle:square
    {
        // Privates:

        float width;

        // Constructors:

        public rectangle()
            : this(10, 20) { }

        public square(float height, float width)
        {
            this.height = height;
            this.width = width;
            X = 5;
            Y = 5;
            Size = 4;
        }

        // height get and set:

        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        public float Width
        {
            get { return width; }
            set { width = value; }
        }

        // Draw overriding:

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Aqua, 4);
            g.DrawRectangle(pen, X, Y, height, width);
        }
    }

    [Serializable]
    class makbilit:rectangle
    {
        // Privates:

        float diagonal;

        // Constructors:

        public makbilit()
            : this(10, 20, 5) { }

        public makbilit(float height, float width, float diagonal)
        {
            this.height = height;
            this.width = width;
            this.diagonal = diagonal;
            X = 5;
            Y = 5;
            Size = 4;
        }

        // height get and set:

        public float Diagonal
        {
            get { return diagonal; }   
            set { diagonal = value; }
        }

        // Draw overriding:

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Aqua, 4);
            g.DrawLine(pen, X, Y, X + diagonal, Y + Height);
            g.DrawLine(pen, X + diagonal, Y + Height, X + diagonal + Width, Y + Height);
            g.DrawLine(pen, X + diagonal + Width, Y + Height, X + 2 * diagonal + Width, Y);
            g.DrawLine(pen, X + 2 * diagonal + Width, Y, X, Y);
        }
    }

}



