﻿using System;
using System.Collections.Generic;

namespace InterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            /*Product vasara = new Product("Vasara", 9.50, 5);
            Console.WriteLine($"Vasaroiden kokonaishinta: {vasara.CalculateTotal()}");
            Console.WriteLine(vasara.ToString());
            Console.WriteLine($"Löydettiin Vasara\n{vasara.GetProduct("Vasara")}");
            Console.WriteLine("-----------------------");*/

            List<Product> productList = new List<Product>()
            {
                new Product("Hammer", 9.50, 5),
                new Product("Axe", 17.00, 20),
                new Product("Nail", 0.05, 1000)
            };

            /*productList.ForEach(Console.WriteLine);
            Console.WriteLine("-----------------------");

            foreach(Product p in productList)
            {
                if (p.GetProduct("Hammer") != null)
                    Console.WriteLine($"Found product Hammer\n{p}");
            }
            Console.WriteLine("-----------------------");

            foreach (Product p in productList)
            {
                Console.WriteLine($"Products {p.Name} in stock {p.Amount}. Total price: {p.CalculateTotal():F2} €");
            }
            Console.WriteLine("-----------------------");*/

            List<Customer> customerList = new List<Customer>
            {
                new Customer("Matti", 4200),
                new Customer("Teppo", 800),
                new Customer("Keijo", 1400)
            };

            /*customerList.ForEach(Console.WriteLine);
            Console.WriteLine("-----------------------");
            foreach (Customer c in customerList)
                if (c.GetCustomer("Teppo") != null)
                    Console.WriteLine($"Found customer Teppo\n{c}");
            Console.WriteLine("-----------------------");*/


            Store store = new Store
            {
                Name = "Heikin kauppa",
                Sales = 45000
            };

            foreach (Product p in productList)
                store.AddProduct(p);

            foreach (Customer c in customerList)
                store.AddCustomer(c);

            Console.WriteLine($"STORE INFO\n{store}");
            Console.WriteLine("-----------------------");
            store.PrintCustomers();
            Console.WriteLine("-----------------------");
            store.PrintProducts();
        }
    }
}