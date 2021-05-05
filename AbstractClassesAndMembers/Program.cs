﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var shape = new Shape(); // cannot create abstract classes

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
