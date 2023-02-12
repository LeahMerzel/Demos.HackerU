namespace Demos.HackerU.OOP
{

    /// <summary>
    /// 1) X,Y Properties must be 0<x<10  0<y<10
    ///  if X bigger 10  set to 10
    ///  if Y smaller 0 set to 0
    /// 2) Constractor 
    ///   - Default Constractor 
    ///   - Full Constaractor
    ///   - one value Constractor
    /// 3) Test each constractor with values
    ///    and call the display method
    /// 
    /// </summary>
    public class Point
    {
        private int x;
        private int y;

        /// <summary>
        /// X between 0 -10
        /// </summary>
        public int X
        {
            get { return x;  }
            set {
                if (value > 10)
                     x = 10;
                else if (value < 0)
                    x = 0;

                x = value;
            
            }
        }

        /// <summary>
        /// y Between 0-10
        /// </summary>
        public int Y {
            get { return y; }
            set {
                if (value > 10)
                    y = 10;
                else if (value < 0)
                    y = 0;

                y= value;
            }
        
        }

        public void Display()
        {
            Console.WriteLine($"X:{X},Y:{Y}");
        }

        public void AddX(int value)
        {
            X += value;
        }

        public void AddY(int value)
        {
            Y += value;
        }

        public void Reset()
        {
            X = 0;
            Y = 0;
        }

    }
}