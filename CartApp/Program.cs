using System;
using System.Runtime.Serialization;

namespace CartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public enum Category
    {
        dairy = 10,
        educational = 20,
        entertainment = 5,
        electronics = 8
    }

    public class DiscountFactory
    {
        public int GenerateDiscount(string category)
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
