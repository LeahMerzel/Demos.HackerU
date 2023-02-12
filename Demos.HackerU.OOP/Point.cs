namespace Demos.HackerU.OOP
{

    /// <summary>
    /// 1) X,Y must be 0<x<10  0<y<10
    ///  if bigger 10  Set to 10
    ///  if smaller 0 set to 0
    /// 2) Constractor 
    ///   - Default Constractor 
    ///   - Full Constaractor
    ///   - one value Constractor
    /// 3) Test Each Constractor with values
    /// 
    /// </summary>
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

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