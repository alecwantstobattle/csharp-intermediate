using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;

namespace InheritanceAccessModifiers
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //var rating = customer.CalculateRating(); // Wont work if method is private
            Amazon.RateCalculator calculator = new RateCalculator(); // Wont work if method is internal (Amazon is referenced)
        }
    }
}
