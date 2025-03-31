
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Security.Cryptography.X509Certificates;
public class Order
{
    private List<Product> _product= new List<Product>();
   private Customer _customer;
   private int _total;



   public void AddProduct(Product product)
   {
    _product.Add(product);
    
   }

   public void GetCustomer(Customer customer)
   {
     _customer = customer;
   }



    public void GetCustomerLabel()
   {
    Console.WriteLine($"Shipping Label:{_customer.GetCustomer()}");
   }


   public void GetShippingLabel()
   {
      foreach(Product product in _product)
      {
       
        string productList = $"{product.GetProductsString()}";

        string[] parts = productList.Split(",");

        Console.WriteLine($"packing label:{parts[0]} {parts[1]}");
      }

   }

  
   public void GetTotalCost()
   {
    foreach(Product product in _product)
    {
      if(_customer.GetCustomerCountry() =="usa")
      {
       _total += product.GetTotalOfProduct();
       _total +=5;
      }
     else
     {
      _total += product.GetTotalOfProduct();
      _total +=35;
      
        
     }
     
    }
    Console.WriteLine($"Total:{_total}");
   }
}