using Microsoft.EntityFrameworkCore;
using ProductMicroservice.DBContexts;
using ProductMicroservice.Model;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ProductMicroservice.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;
        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            _dbContext.Products.Remove(product);
            Save();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByID(int productId)
        {
            return _dbContext.Products.Find(productId);
        }
        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }
        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();
        }

        object IProductRepository.GetProductByID(int id)
        {
            throw new NotImplementedException();
        }

        object IProductRepository.GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}