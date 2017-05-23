using System;


namespace DrawingTool
{
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Square : Shape
    {
        int side;
        public Square(int side)
        {
            this.side = side;
        }
        public override void Draw()
        {
            Console.WriteLine("{0}{1}{0}", '|', new string ('-', side));
            for (int i = 0; i < side - 2;  i++)
            {
                Console.WriteLine("{0}{1}{0}", '|', new string(' ', side));
            }
            Console.WriteLine("{0}{1}{0}", '|', new string('-', side));
        }
    }

    public class Rectangle : Shape
    {
        int lenght;
        int width;
        public Rectangle(int lenght, int width)
        {
            this.lenght = lenght;
            this.width = width;
        }
        public override void Draw()
        {
            Console.WriteLine("{0}{1}{0}", '|', new string('-',width));
            for (int i = 0; i < lenght - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", '|',new string(' ', width));
            }
            Console.WriteLine("{0}{1}{0}", '|', new string('-', width));
        }
    }
    public class CorDraw
    {
        public CorDraw(Shape shape)
        {
            Draw(shape);
        }
        public void Draw (Shape shape)
        {
            shape.Draw();
        }
    }
    class DrawingTool
    {
        static void Main(string[] args)
        {
            Shape shape;
            string typeOfShape = Console.ReadLine();
            if (typeOfShape == "Square")
            {
                Square square = new Square(int.Parse(Console.ReadLine()));
                shape = square;
            }
            else
            {
                int width = int.Parse(Console.ReadLine());
                int length = int.Parse(Console.ReadLine());
                Rectangle rec = new Rectangle(length, width);
                shape = rec;
            }
            shape.Draw();
        }
    }
}
