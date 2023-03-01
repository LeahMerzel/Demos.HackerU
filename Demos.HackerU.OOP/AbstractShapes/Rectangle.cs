using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.AbstractShapes
{
    public class Rectangle : Shape
    {
        private int _height;
        private int _width;
        public int Height { get => _height; set => _height = value; }
        public int Width { get => _width; set => _width = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="color"></param>
        public Rectangle(int height, int width, Colors color) : base(color)
        {
            _height = height;
            _width = width;
        }

        public Rectangle(int size, Colors color) : base(color)
        {
            _height = size;
            _width = size;
        }


        /// <summary>
        /// 
        /// </summary>
        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
           return Height * 2 + Width * 2;
        }


        public override string ToString()
        {
            return base.ToString()+ $"Width:{Width} Height:{Height}";
        }
    }
}
