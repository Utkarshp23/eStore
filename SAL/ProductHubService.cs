namespace SAL;
using BLL;
using BOL;
public class ProductHubService
{
  public List<Product> GetAllProducts()
  {
    ProductManager theProductManager = ProductManager.GetProductManager();
    List<Product> products = theProductManager.GetAllProducts();
    return products;
  }

  public Product GetProductById(int id)
  {
    ProductManager theProductManager = ProductManager.GetProductManager();
    Product p = theProductManager.GetProductById(id);

    return p;
  }

  public bool AddProduct(Product p)
  {
    ProductManager theProductManager = ProductManager.GetProductManager();
    return theProductManager.AddProduct(p);
  }

  public bool RemoveProduct(int id)
  {
    ProductManager theProductManager = ProductManager.GetProductManager();
    return theProductManager.RemoveProduct(id);
  }

}
