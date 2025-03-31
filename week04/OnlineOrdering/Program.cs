using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");



        Address address = new Address("No 5 Ehigba strets","owan west","Edo State","Nigeria");
        // address.SetAddress("No 5 Ehigba strets","owan west","Edo State","Nigeria");

        string customerName = "Ojeaga clifford";
        Customer customer = new Customer();

        customer.SetCustomer(customerName,address);
        Product product1 = new Product("Rice",4,200,2);
        Product product2 = new Product("Beans",5,300,2);
        Product product3 = new Product("Yam",6,600,2);
        

        Order order = new Order();
         order.GetCustomer(customer);
          order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);
        
        order.GetCustomerLabel();
        order.GetShippingLabel();
       
        order.GetTotalCost();
        Console.WriteLine("");

        Address address1 = new Address("no 6 Utah","North","Utah","usa");
        // address.SetAddress("No 5 Ehigba strets","owan west","Edo State","Nigeria");

        string customerName1 = "John Smith";
        Customer customer1 = new Customer();

        customer1.SetCustomer(customerName1,address1);
        Product product4 = new Product("Rice",4,200,5);
        Product product6 = new Product("Green beans",5,150,6);
        Product product7 = new Product("Yam",6,600,2);
        

        Order order1 = new Order();
        order1.GetCustomer(customer1);
        order1.AddProduct(product4);
        order1.AddProduct(product6);
        order1.AddProduct(product7);
        
        order1.GetCustomerLabel();
        order1.GetShippingLabel();
        
        order1.GetTotalCost();
        
    }
}