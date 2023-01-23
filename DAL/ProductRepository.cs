namespace DAL;
using BOL;
public static class ProductRepository
{

  public static List<Product> allProducts = new List<Product>(){

    new Product { ProductId = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", StockAvailable = 5000 },
    new Product { ProductId = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Category = "Flower", StockAvailable = 7000 },
    new Product { ProductId = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Category = "Flower", StockAvailable = 3400 },
    new Product { ProductId = 4, Title = "Carnation", Description = " white for good luck", UnitPrice = 16, Category = "Flower", StockAvailable = 27000 },
    new Product { ProductId = 5, Title = "Lily", Description = "flowers in the U.S.", UnitPrice = 6, Category = "Flower", StockAvailable = 1000 },
    new Product { ProductId = 6, Title = "Jasmine", Description = "the olive family", UnitPrice = 26, Category = "Flower", StockAvailable = 2000 },
    new Product { ProductId = 7, Title = "Daisy", Description = " pure intentions.", UnitPrice = 36, Category = "Flower", StockAvailable = 159 }
  };

  public static List<Product> GetAllProducts()
  {
    // List<Product> allProducts=new List<Product>();
    // allProducts.Add(new Product { ProductId = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", StockAvailable = 5000 });
    // allProducts.Add(new Product { ProductId = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Category = "Flower", StockAvailable = 7000 });
    // allProducts.Add(new Product { ProductId = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Category = "Flower", StockAvailable = 3400 });
    // allProducts.Add(new Product { ProductId = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Category = "Flower", StockAvailable = 27000 });
    // allProducts.Add(new Product { ProductId = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Category = "Flower", StockAvailable = 1000 });
    // allProducts.Add(new Product { ProductId = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", UnitPrice = 26, Category = "Flower", StockAvailable = 2000 });
    // allProducts.Add(new Product { ProductId = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Category = "Flower", StockAvailable = 159 });
    // allProducts.Add(new Product { ProductId = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Category = "Flower", StockAvailable = 67 });
    // allProducts.Add(new Product { ProductId = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", StockAvailable = 5000 });
    // allProducts.Add(new Product { ProductId = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Category = "Flower", StockAvailable = 0 });
    // allProducts.Add(new Product { ProductId = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Category = "Flower", StockAvailable = 0 });
    // allProducts.Add(new Product { ProductId = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Category = "Flower", StockAvailable = 700 });
    // allProducts.Add(new Product { ProductId = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Category = "Flower", StockAvailable = 1500 });
    // allProducts.Add(new Product { ProductId = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Category = "Flower", StockAvailable = 2300 });
    // allProducts.Add(new Product { ProductId = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Category = "Flower", StockAvailable = 10000 });
    return allProducts;
  }

  public static Product GetProductById(int id)
  {
    // List<Product> products = GetAllProducts();
    // System.Console.WriteLine("id:" + id);
    // System.Console.WriteLine(products[0].Title);
    // var theProduct = from prod in allProducts
    //                  where prod.ProductId == id
    //                  select prod;
    var theProduct = allProducts.First(i => i.ProductId == id);
    // Product p = (Product)theProduct;
    // Product theProduct=GetById(id);
    // System.Console.WriteLine(p.Title);
    return theProduct as Product;
  }

  public static bool AddProduct(Product p)
  {
    allProducts.Add(p);
    return true;
  }

  public static bool RemoveProduct(int id)
  {
    List<Product> products=allProducts;
    Product p=GetProductById(id);
    products.Remove(p);
    return true;
  }
}
