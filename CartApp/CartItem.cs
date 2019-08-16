namespace CartApp
{
    public class CartItem 
    {
        public int Quantity;
        public readonly Product Product;
        public Discount Discount = new Discount();
        public CartItem(Product product,int quantity,double discount=0.0)
        {
            Quantity = quantity;
            Product = product;
            Discount.Value = discount;
        }
    }
}
