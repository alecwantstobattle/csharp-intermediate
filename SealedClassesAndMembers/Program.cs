using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassesAndMembers
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();
    }

    //public sealed class Circle: Shape // cannot create a class that derive from circle
    public class Circle: Shape
    {
        public sealed override void Draw() // can only be applied to methods that are overriding a virtual method in a base class
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
