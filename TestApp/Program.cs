// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using BOL;

// Console.WriteLine("Hello, World!");

// *******Adding products in File--->
// List<Product> allProducts = new List<Product>();
// allProducts.Add(new Product { ProductId = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", StockAvailable = 5000 });
// allProducts.Add(new Product { ProductId = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Category = "Flower", StockAvailable = 7000 });
// allProducts.Add(new Product { ProductId = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Category = "Flower", StockAvailable = 3400 });
// allProducts.Add(new Product { ProductId = 4, Title = "Carnation", Description = "white for good luck", UnitPrice = 16, Category = "Flower", StockAvailable = 27000 });
// allProducts.Add(new Product { ProductId = 5, Title = "Lily", Description = " the U.S.", UnitPrice = 6, Category = "Flower", StockAvailable = 1000 });
// allProducts.Add(new Product { ProductId = 6, Title = "Jasmine", Description = " olive family", UnitPrice = 26, Category = "Flower", StockAvailable = 2000 });
// allProducts.Add(new Product { ProductId = 7, Title = "Daisy", Description = " and pure intentions.", UnitPrice = 36, Category = "Flower", StockAvailable = 159 });
// allProducts.Add(new Product { ProductId = 8, Title = "Aster", Description = "A anniversary flower.", UnitPrice = 16, Category = "Flower", StockAvailable = 67 });
// allProducts.Add(new Product { ProductId = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", StockAvailable = 5000 });
// allProducts.Add(new Product { ProductId = 10, Title = "Dahlia", Description = "Dahlias are .", UnitPrice = 7, Category = "Flower", StockAvailable = 0 });
// allProducts.Add(new Product { ProductId = 11, Title = "Hydrangea", Description = "Hydrangea is ", UnitPrice = 12, Category = "Flower", StockAvailable = 0 });
// allProducts.Add(new Product { ProductId = 12, Title = "Orchid", Description = "Orchids are ein your life.", UnitPrice = 10, Category = "Flower", StockAvailable = 700 });
// allProducts.Add(new Product { ProductId = 13, Title = "Statice", Description = "Surprise flowers", UnitPrice = 16, Category = "Flower", StockAvailable = 1500 });
// allProducts.Add(new Product { ProductId = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Category = "Flower", StockAvailable = 2300 });
// allProducts.Add(new Product { ProductId = 15, Title = "Tulip", Description = "Tulips are the to June.", UnitPrice = 17, Category = "Flower", StockAvailable = 10000 });

List<Customer> customers = new List<Customer>();
customers.Add(new Customer { Fname = "Utkarsh", Lname = "Pawar", Cnum = "8975207820", Location = "Pune", Email = "utkarshpawar2332@gmail.com", Password = "root1234" });

string jsonString = JsonSerializer.Serialize(customers);
File.WriteAllText("../customers.json", jsonString);
