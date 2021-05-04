using Amazon;

namespace InheritanceAccessModifiers

{
    public class GoldCustomer : Customer
    { 
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrders: true); // affected when business logic of Customer is changed.
        }
    }
}
