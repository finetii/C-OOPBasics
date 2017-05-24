using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntersection
{
    public class Rectangle
    {
        public string ID;
        public double width;
        public double height;
        public double x;
        public double y;

        public Rectangle(string ID, double width, double height, double x, double y)
        {
            this.ID = ID;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public string Intersection(Rectangle rect)
        {
            if ((rect.y >= y && rect.y - rect.height <= y && rect.x <= x && rect.x + rect.width >= x) ||
                ((rect.y >= y && rect.y - rect.height <= y && rect.x >= x && rect.x <= x + width) ||
                (rect.y <= y && rect.y >= y - height && rect.x <= x && rect.x + rect.width >= x) ||
                (rect.y <= y && rect.y >= y - height && rect.x >= x && rect.x <= x + width)))
            {
                return "true";
            }

            else
                return "false";
        }
    }
    class RectangleIntersection
    {
        static void Main(string[] args)
        {
            int[] checks = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < checks[0]; i++)
            {
                string[] rectangleParams = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                rectangles.Add(new Rectangle(rectangleParams[0], double.Parse(rectangleParams[1]), double.Parse(rectangleParams[2]), double.Parse(rectangleParams[3]), double.Parse(rectangleParams[4])));
            }

            for (int i = 0; i < checks[1]; i++)
            {
                string[] rects = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Rectangle r1 = rectangles.Where(r => r.ID == rects[0]).FirstOrDefault();
                Rectangle r2 = rectangles.Where(r => r.ID == rects[1]).FirstOrDefault();
                Console.WriteLine(r1.Intersection(r2));
            }
        }
    }
}
