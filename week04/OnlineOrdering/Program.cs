using System;

class Program
{
    static void Main(string[] args)
    {
        Order bradleyOrder= new  Order(new Customer("James Bradley", new Address("1600 Pennsylvania Avenue","Washington","DC","USA")));
        bradleyOrder.AddProduct(new Product("LV Shoe", 213, 12.5,2));
        bradleyOrder.AddProduct(new Product("PS4", 154, 600,1));
        bradleyOrder.AddProduct(new Product("Gucci T-shirt", 56, 9.3,5));

        Console.Clear();
        Console.WriteLine("================================================================");
        Console.WriteLine("");
        Console.WriteLine("__________________Order Details__________________");
        Console.WriteLine($"{bradleyOrder.GetPackingLabel()}");
        Console.WriteLine($"Total Amount (Without Shipping Fee): ${bradleyOrder.TotalPriceWithoutShipFee()}");
        Console.WriteLine($"Total Cost (Including Shipping Fee): ${bradleyOrder.TotalOrderCost()}");
        Console.WriteLine("________________________________________________________________");
        Console.WriteLine($"To: {bradleyOrder.GetShippingLabel()}");
        Console.WriteLine("================================================================");
        
        Console.WriteLine("");

        Order blakesOrder= new  Order(new Customer("Blake Ayo", new Address("123 Main Street","Lekki","Lagos","Nigeria")));
        blakesOrder.AddProduct(new Product("LV wrist-watch", 419, 50.0,2));
        blakesOrder.AddProduct(new Product("Nike Sneakers", 269, 75,3));
        blakesOrder.AddProduct(new Product("Gucci jean-trouser", 5554, 9.4,4));

        Console.WriteLine("================================================================");
        Console.WriteLine("");
        Console.WriteLine("__________________Order Details__________________");
        Console.WriteLine($"{blakesOrder.GetPackingLabel()}");
        Console.WriteLine($"Total Amount (Without Shipping Fee): ${blakesOrder.TotalPriceWithoutShipFee()}");
        Console.WriteLine($"Total Cost (Including Shipping Fee): ${blakesOrder.TotalOrderCost()}");
        Console.WriteLine("________________________________________________________________");
        Console.WriteLine($"To: {blakesOrder.GetShippingLabel()}");
        Console.WriteLine("================================================================");


        //Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}