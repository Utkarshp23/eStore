namespace BLL;
using BOL;
using DAL;

public class CustomerManager
{
  public static CustomerManager _ref = null;

  private CustomerManager()
  {

  }

  public static CustomerManager GetCustomerManager()
  {
    if (_ref == null)
    {
      _ref = new CustomerManager();
    }
    return _ref;
  }

  // public List<Product> GetAllProducts()
  // {
  //   List<Product> products = ProductRepository.GetAllProducts();
  //   return products;
  // }

  public Customer GetCustomerByEmailAndPassword(string email, string password)
  {
    Customer p = CustomerRepository.GetCustomerByEmailAndPassword(email, password);

    return p;

  }

  public bool AddCustomer(Customer c)
  {
    return CustomerRepository.AddCustomer(c);
  }

  // public bool RemoveProduct(int id)
  // {
  //   return ProductRepository.RemoveProduct(id);
  // }
}
