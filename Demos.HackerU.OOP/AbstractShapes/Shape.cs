using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.AbstractShapes
{
    public abstract class Shape
    {
        //--fields
        private double _area; //--claculate
        private double _perimeter; //--calculate
        private ShapeColor _color; //--data

        /// <summary>
        /// Empty Ctor
        /// </summary>
        public Shape():this(ShapeColor.White)
        {
            _area = 0;
            _perimeter = 0;

        }

        /// <summary>
        /// Full Ctor
        /// </summary>
        /// <param name="color"></param>
        public Shape(ShapeColor color)
        {
            _color = color;
        }

        /// <summary>
        /// Color Emum
        /// </summary>
        public ShapeColor Color { get => _color; set => _color = value; }

        //public double Area
        //{
        //    get { return _area; }
        //    set { _area = value; CalculateArea(); }
        //}

        //public double Perimeter
        //{
        //    get { return _perimeter; }
        //    set { _perimeter = value; CalculatePerimeter(); }
        //}

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public override string ToString()
        {
            return $"Color:{_color}";
        }
    }

    public enum ShapeColor
    {
        Black,
        White,
        Blue,
        Green,
        Yellow,
        Red
    }
}
