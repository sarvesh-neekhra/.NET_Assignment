using System;

namespace InheritanceDemo
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Product ID: " + ProductId);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
        }
    }


    public class ElectronicsProduct : Product
    {
        public string Brand { get; set; }
        public int WarrantyInYears { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("Product ID: " + ProductId);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Warranty: " + WarrantyInYears + " Years");
        }
    }

    internal class Program1
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            p.ProductId = 101;
            p.ProductName = "Notebook";
            p.Price = 50;

            Console.WriteLine("----- Product Details -----");
            p.DisplayInfo();

            Console.WriteLine();

           
            ElectronicsProduct ep = new ElectronicsProduct();

            ep.ProductId = 201;
            ep.ProductName = "Laptop";
            ep.Price = 55000;
            ep.Brand = "Dell";
            ep.WarrantyInYears = 2;

            Console.WriteLine("----- Electronics Product Details -----");
            ep.DisplayInfo();

            Console.ReadLine();
        }
    }
}