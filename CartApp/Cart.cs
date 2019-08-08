using System.Collections.Generic;

namespace CartApp
{
    public class Cart
    {
        private List<CartItem> _cartItem = new List<CartItem>();

        public void Add(CartItem item)
        {
            _cartItem.Add(item);
        }

        public void Remove(CartItem item)
        {
            _cartItem.Remove(item);
        }

        public List<CartItem> ViewItems()
        {
            return _cartItem;
        }

       
        public  double GetTotalCost()
        {
            var totalCost = 0.0;
            foreach(var item in _cartItem)
            {
                var discountedPrice = (item.Product.Price*item.Quantity) - (item.Discount.Value/100 * item.Product.Price);
                totalCost += discountedPrice;
            }

            return totalCost;
        }


    }
}
