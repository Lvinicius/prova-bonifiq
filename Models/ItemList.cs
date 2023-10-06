namespace ProvaPub.Models
{
    public class ListResponse<T>
    {
        public List<T> Items { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
    }

    public class ProductList : ListResponse<Product>
    {
      
    }

    public class CustomerList : ListResponse<Customer>
    {
      
    }
}
