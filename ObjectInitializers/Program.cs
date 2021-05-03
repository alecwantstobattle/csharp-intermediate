using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Mosh",
                LastName = "Hamedani"
            };
        }
    }
}
