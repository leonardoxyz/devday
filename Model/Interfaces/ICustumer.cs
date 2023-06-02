namespace devdayapi.Model.Interfaces
{
  public interface ICustumer
  {
    void Add(Customer customer);
    IEnumerable<Customer> GetAll();
  }
}