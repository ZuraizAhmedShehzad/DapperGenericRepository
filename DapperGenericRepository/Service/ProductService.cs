using DapperGenericRepository.Model;
using DapperGenericRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperGenericRepository.Service
{
    public class ProductService
    {
        public bool Add(Product product)
        {
            bool isAdded = false;
            try
            {
                ProductRepository productRepository = new ProductRepository();
                isAdded = productRepository.Add(product);
            }
            catch(Exception ex)
            {
            }
            return isAdded;
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            try
            {
                ProductRepository productRepository = new ProductRepository();
                products = productRepository.GetAll().ToList();
            }
            catch (Exception ex)
            {
            }

            return products;
        }

        public Product Get(int Id)
        {
            Product product = new Product();
            try
            {
                ProductRepository productRepository = new ProductRepository();
                product = productRepository.GetById(Id);
            }
            catch (Exception ex)
            {
            }

            return product;
        }

        public bool Update(Product product)
        {
            bool isUpdated = false;
            try
            {
                ProductRepository productRepository = new ProductRepository();
                isUpdated = productRepository.Update(product);
            }
            catch (Exception ex)
            {
            }

            return isUpdated;
        }

        public bool Delete(Product product)
        {
            bool isDeleted = false;
            try
            {
                ProductRepository productRepository = new ProductRepository();
                isDeleted = productRepository.Delete(product);
            }
            catch (Exception ex)
            {
            }
            return isDeleted;
        }
    }
}
