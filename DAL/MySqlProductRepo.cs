namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public static class MySqlProductRepo
{
  public static string connstring = @"Server=localhost;User ID=root;Password=root;Database=ecommerce";

  public static List<Product> GetAllProducts()
  {
    List<Product> allproducts = new List<Product>();
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString=connstring;
    MySqlCommand cmd = new MySqlCommand();
    cmd.Connection = conn;

    cmd.CommandText = "select * from products";

    try
    {
      conn.Open();
      MySqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        int id = int.Parse(reader["productid"].ToString());
        string title = reader["title"].ToString();
        string desc = reader["description"].ToString();
        int unitprice = int.Parse(reader["unitprice"].ToString());
        // int aval = int.Parse(reader["available"].ToString());
        int stock = int.Parse(reader["unitinstock"].ToString());
        Product p = new Product { ProductId = id, Title = title, Description = desc, UnitPrice = unitprice, StockAvailable = stock };
        allproducts.Add(p);
      }
    }
    catch (Exception e)
    {
      System.Console.WriteLine(e.Message);
    }
    finally
    {
      conn.Close();
    }

    return allproducts;
  }
}

