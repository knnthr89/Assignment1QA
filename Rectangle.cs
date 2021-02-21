using System;
namespace Assignment1QA
{
    public class Rectangle
    {
        private int width;
        private int length;

        public Rectangle()
        {
            this.width = 1;
            this.length = 1;
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.length = height;
        }

        public int GetLenght()
        {
            return this.length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetPerimeter()
        {
            return 2 * (this.length + this.width);
        }

        public int GetArea()
        {
            return this.width * this.length;
        }
    }
}
