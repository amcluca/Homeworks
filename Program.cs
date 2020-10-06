using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {

            
            DateTime productionDate1 = new DateTime(2020, 10, 04);
            DateTime productionDate2 = new DateTime(2020, 10, 04);
            DateTime productionDate3 = new DateTime(2020, 10, 04);
            DateTime productionDate4 = new DateTime(2020, 10, 04);
            DateTime expirationDate1 = new DateTime(2020, 10, 11);
            DateTime expirationDate2 = new DateTime(2020, 10, 06);
            DateTime expirationDate3 = new DateTime(2023, 10, 04);
            DateTime expirationDate4 = new DateTime(2020, 10, 08);
            Product product1 = new Product(ProductWeight.one_liter, ProductName.Milk, productionDate1, 
                                          expirationDate1, ProductProducer.Zuzu, ProductCategory.Dairy);
            Product product2 = new Product(ProductWeight.one_kilo, ProductName.Apple, productionDate2, 
                                          expirationDate2, ProductProducer.Golden, ProductCategory.Fruits);
            Product product3 = new Product(ProductWeight.one_liter, ProductName.Wine, productionDate3, 
                                       expirationDate3, ProductProducer.Cotnari, ProductCategory.Beverages);
            Product product4 = new Product(ProductWeight.one_kilo, ProductName.Bread, productionDate4, 
                                          expirationDate4, ProductProducer.Panifcom, ProductCategory.Bread);

            Console.WriteLine("Product Number One has: " + product1.Weight);
            Console.WriteLine("Product Number One is: " + product1.Name);
            Console.WriteLine("Production date of Product Number One is: " + productionDate1.ToString("MM/dd/yyyy"));
            Console.WriteLine("Expiration date of Product Number One is: " + expirationDate1.ToString("MM/dd/yyyy"));
            Console.WriteLine("Producer of Product Number One is: " + product1.Producer);
            Console.WriteLine("");

            Console.WriteLine("Product Number Two has: " + product2.Weight);
            Console.WriteLine("Product Number Two is: " + product2.Name);
            Console.WriteLine("Production date of Product Number Two is: " + productionDate2.ToString("MM/dd/yyyy"));
            Console.WriteLine("Expiration date of Product Number Two is: " + expirationDate2.ToString("MM/dd/yyyy"));
            Console.WriteLine("Producer of Product Number Two is: " + product2.Producer);
            Console.WriteLine("");

            Console.WriteLine("Product Number Three has: " + product3.Weight);
            Console.WriteLine("Product Number Three is: " + product3.Name);
            Console.WriteLine("Production date of Product Number Three is: " + productionDate3.ToString("MM/dd/yyyy"));
            Console.WriteLine("Expiration date of Product Number Three is: " + expirationDate3.ToString("MM/dd/yyyy"));
            Console.WriteLine("Producer of Product Number Three is: " + product3.Producer);
            Console.WriteLine("");

            Console.WriteLine("Product Number Four has: " + product4.Weight);
            Console.WriteLine("Product Number Four is: " + product4.Name);
            Console.WriteLine("Production date of Product Number Four is: " + productionDate4.ToString("MM/dd/yyyy"));
            Console.WriteLine("Expiration date of Product Number Four is: " + expirationDate4.ToString("MM/dd/yyyy"));
            Console.WriteLine("Producer of Product Number Four is: " + product4.Producer);
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
