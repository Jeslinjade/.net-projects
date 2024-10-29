using ProductMicroservices.Model;
using System.Collections.Generic;
namespace ProductMicroservices.Repository
{

    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int Productid);
        void InsertProduct(Product product);
        void DeleteProduct(int Productid);
        void UpdateProduct(Product product);
        void Save();


    }
}
