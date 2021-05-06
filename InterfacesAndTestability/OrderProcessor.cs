using System;

namespace InterfacesAndTestability
{
    public class OrderProcessor
    {
        //private readonly ShippingCalculator _shippingCalculator;
        private readonly IShippingCalculator _shippingCalculator;
        //public OrderProcessor()
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            //_shippingCalculator = new ShippingCalculator();
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
