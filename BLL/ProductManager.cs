namespace BLL;
using DAL;
using BOL;

public class ProductManager
{
  public static ProductManager _ref=null;

  private ProductManager()
  {

  }

  public static ProductManager GetProductManager()
  {
    if(_ref==null)
    {
      _ref= new ProductManager();
    }
    return _ref;
  }

  public List<Product> GetAllProducts()
  {
    List<Product> products=ProductRepository.GetAllProducts();
    return products;
  }

  public Product GetProductById(int id)
  {
    Product p= ProductRepository.GetProductById(id);
    return p;
  }

  public bool AddProduct(Product p)
  {
    return ProductRepository.AddProduct(p);
  }
}
