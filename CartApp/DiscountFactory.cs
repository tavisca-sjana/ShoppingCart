namespace CartApp
{
    public class DiscountFactory
    {
        public int GetDiscount(string category)
        {
            switch(category.ToLowerInvariant())
            {
                case "educational":
                    return (int)Category.educational;
                case "diary":
                    return (int)Category.dairy;
                case "entertainment":
                    return (int)Category.entertainment;
                case "electronics":
                    return (int)Category.electronics;
                default:
                    throw new CategoryNotImplementedException();
                    
                  

            }
        }
    }
   


}
