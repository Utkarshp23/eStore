namespace SAL;
using BLL;
using BOL;
public class CustomerService
{
  // public List<Customer> GetAllProducts()
  // {
  //   ProductManager theProductManager = ProductManager.GetProductManager();
  //   List<Product> products = theProductManager.GetAllProducts();
  //   return products;
  // }

  public Customer GetCustomerByEmailAndPassword(string email, string password)
  {
    CustomerManager theCustomerManager = CustomerManager.GetCustomerManager();
    Customer c = theCustomerManager.GetCustomerByEmailAndPassword(email, password);

    return c;

  }

  public bool AddCustomer(Customer c)
  {
    CustomerManager theCustomerManager = CustomerManager.GetCustomerManager();
    return theCustomerManager.AddCustomer(c);
  }

  // public bool RemoveProduct(int id)
  // {
  //   ProductManager theProductManager = ProductManager.GetProductManager();
  //   return theProductManager.RemoveProduct(id);
  // }

}
