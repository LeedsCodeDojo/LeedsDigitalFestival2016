using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceLib
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static double distance (Point p1, Point p2)
        {
            var result = Math.Abs(p1.Y - p2.Y) +
                Math.Abs((p1.X + 0.5 * p1.Y) - (p2.X + 0.5 * p2.Y));
            return result;
        }
    }
    public class Calculator
    {
        private Dictionary<char, Point> keymap = new Dictionary<char, Point>();

        public Calculator()
        {
            string[] keyboard = { "1234567890", "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            for (var y = 0; y < keyboard.Length; y++)
            {
                for (var x = 0; x < keyboard[y].Length; x++)
                {
                    keymap.Add(keyboard[y][x], new Point { X = x, Y = y });
                    //keymap[keyboard[y][x]] = (x, y);
                }
            }
        }

        public double distance(string a, string b)
        {
            if (a == b) return 0;
            if (a.Length != b.Length)
                return 100;
            var dist = 0.0;
            for (var i=0; i<a.Length; i++)
            {
                dist += Point.distance(keymap[a[i]], keymap[b[i]]);
            }

            return dist / a.Length;
           
        }
    }
}