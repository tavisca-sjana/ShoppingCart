using System;
using Xunit;
using CartApp;
using System.Collections.Generic;

namespace CartTests
{
    public class CartFixture
    {
        [Fact]
        public void cart_total_cost_0_when_cart_empty()
        {
          
            Cart cart = new Cart();

            double expectedValue = 0.0;

            Assert.Equal(expectedValue, cart.GetTotalCost());
        }

        [Fact]
        public void add_item_functionality_of_cart_test()
        {
            Product product = new Product();
            product.Name = "Book";
            product.Price = 143.89;
            int quantity = 2;
            

            CartItem cartItem = new CartItem(product, quantity);

            Cart cart = new Cart();
            cart.Add(cartItem);

            List<CartItem> listOfExpectedItems = new List<CartItem>()
            {
                cartItem
            };

            Assert.Equal(listOfExpectedItems, cart.GetItems());


        
        }

        [Fact]
        public void remove_item_functionality_of_cart_test()
        {
            Product product = new Product();
            product.Name = "Book";
            product.Price = 143.89;
            int quantity = 2;


            CartItem cartItem = new CartItem(product, quantity);

            Cart cart = new Cart();
            cart.Add(cartItem);
            cart.Remove(cartItem);
            List<CartItem> listOfExpectedItems = new List<CartItem>();
            
            Assert.Equal(listOfExpectedItems, cart.GetItems());



        }

        [Fact]
        public void discounted_price_of_item_test()
        {
            Product product = new Product();
            product.Name = "Book";
            product.Price = 143.89;
            int quantity = 1;
            double discount = 20.0;

            CartItem cartItem = new CartItem(product, quantity,discount);

            Cart cart = new Cart();
            cart.Add(cartItem);
            
            double expectedValue = 115.11;

            Assert.Equal(expectedValue,Math.Round(cart.GetTotalCost(),2));

            
        }

        [Fact]
        public void total_cost_of_cart_functionality_test()
        {
            Product product = new Product();
            product.Name = "Book";
            product.Price = 143.89;
            int quantity = 2;


            CartItem cartItem = new CartItem(product, quantity);

            Cart cart = new Cart();
            cart.Add(cartItem);
            double expectedValue = 287.78;

            Assert.Equal(expectedValue, Math.Round(cart.GetTotalCost(),2));

        }

        [Fact]
        public void discounted_price_of_item_based_on_category_test()
        {
            Product product = new Product();
            product.Name = "Book";
            product.Price = 143.89;
            int quantity = 1;
            
            CartItem cartItem = new CartItem(product, quantity, new DiscountFactory().GetDiscount("educational"));

            Cart cart = new Cart();
            cart.Add(cartItem);

            double expectedValue = 115.11;

            Assert.Equal(expectedValue, Math.Round(cart.GetTotalCost(), 2));


        }
    }
}
