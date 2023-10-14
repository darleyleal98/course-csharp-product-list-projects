using course_product_list.Entities;
using System;

namespace Course
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of products: ");
            int quantityOfProducts = int.Parse(Console.ReadLine());

            List<Product> listProducts = new List<Product>();

            for (int i = 0; i < quantityOfProducts; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");

                Console.Write("Common, used or imported (C/U/I)? ");
                string productType = Console.ReadLine().ToUpper();

                Console.Write("Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine());

                switch(productType)
                {
                    case "C":
                        listProducts.Add(new Product(productName, productPrice));
                        break;

                    case "U":
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        listProducts.Add(new UsedProduct(productName, productPrice, manufactureDate));
                        break;

                    case "I":
                        Console.Write("Customs Fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        listProducts.Add(new ImportedProduct(productName, productPrice, customsFee));
                        break;

                    default:
                        throw new Exception("Option don't exist! Try again!");
                        break;
                }
            }
        }
    }
}