﻿using Demos.HackerU.OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.AbstractShapes
{
    /// <summary>
    /// * Implement ILogger for both Rectangle 
    ///  public interface ILogger   
         //-void Log(string text, int level);
        // -void Log(string text, int level, string fileName);
/// </summary>
public class Rectangle : Shape , ILogger
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
        public Rectangle(int height, int width, ShapeColor color) : base(color)
        {
            _height = height;
            _width = width;
        }

        public Rectangle(int size, ShapeColor color) : base(color)
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
            return  $" Width:{Width} Height:{Height}" + base.ToString();
        }

        public void Log(string text, int level)
        {
            Console.WriteLine(text + " (" + level + ")");
        }

        public void Log(string text, int level, string fileName)
        {
            var logEntry = string.Format("{0}-{1}" + Environment.NewLine, text, level);
            File.WriteAllText(fileName, logEntry);
        }
    }
}
