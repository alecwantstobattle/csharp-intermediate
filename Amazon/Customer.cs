using System;

namespace Amazon
{
    public class Customer // trasferred to show internal modifier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public void Promote()
        //{
        //    var rating = CalculateRating(excludeOrders: true);
        //    if (rating == 0)
        //        Console.WriteLine("Promoted to Level 1");
        //    else
        //        Console.WriteLine("Promoted to Level 2");
        //}

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed.");
        }

        //public int CalculateRating()
        //private int CalculateRating(bool excludeOrders)
        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
