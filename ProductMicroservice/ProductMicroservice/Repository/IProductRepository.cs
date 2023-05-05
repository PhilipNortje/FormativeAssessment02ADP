using ProductMicroservice.Model;
using System.Collections.Generic;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();

        Product GetById(int id);

        void InsertProduct(Product product);

        void DeleteProduct(int ProductId);

        void UpdateProduct(Product product);

        void Save();
        object GetProducts();
        object GetProductByID(int id);
    }
}
