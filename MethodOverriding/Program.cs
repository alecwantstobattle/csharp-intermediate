using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{

    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            //shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Circle });
            //shapes.Add(new Shape { Width = 100, Height = 30, Type = ShapeType.Rectangle });
            shapes.Add(new Circle());
            shapes.Add(new Rectange());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
