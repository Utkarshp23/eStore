namespace DAL;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using BOL;
using MySql.Data.MySqlClient;
public static class ProductRepository
{

  public static List<Product> allProducts = JsonSerializer.Deserialize<List<Product>>(File.ReadAllText("../products.json"));


  public static List<Product> GetAllProducts()
  {
    // string productString = File.ReadAllText("../products.json");
    // List<Product> allProducts = JsonSerializer.Deserialize<List<Product>>(productString);
    // MySqlConnection conn= new MySqlConnection();

    return allProducts;
  }

  public static Product GetProductById(int id)
  {

    var theProduct = allProducts.First(i => i.ProductId == id);
    return theProduct as Product;
  }

  public static bool AddProduct(Product p)
  {
    allProducts.Add(p);
    string jsonString = JsonSerializer.Serialize(allProducts);
    File.WriteAllText("../products.json", jsonString);
    return true;
  }

  public static bool RemoveProduct(int id)
  {
    List<Product> products = allProducts;
    Product p = GetProductById(id);
    products.Remove(p);
    string jsonString = JsonSerializer.Serialize(allProducts);
    File.WriteAllText("../products.json", jsonString);
    return true;
  }
}
