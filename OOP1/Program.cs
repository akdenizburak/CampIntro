using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { Id = 1, CategoryId = 2, ProductName = "Masa", UnitPrice = 500, UnitsInStock = 3 };
            Product product2 = new Product { Id = 2, CategoryId = 3, ProductName = "Kalem", UnitPrice = 78, UnitsInStock = 200 };
            ProductManager productManager = new ProductManager();
            productManager.Add();

        }
    }
}
