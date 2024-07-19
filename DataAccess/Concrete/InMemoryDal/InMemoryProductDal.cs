using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryDal
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
               new Product{CategoryId=1,ProductId=1,ProductName="Fincan",UnitPrice=15,UnitsInStock=10},    
               new Product{CategoryId=1,ProductId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
               new Product{CategoryId=2,ProductId=3,ProductName="Telefon",UnitPrice=1500,UnitsInStock=10},
               new Product{CategoryId=2,ProductId=4,ProductName="Sican",UnitPrice=150,UnitsInStock=190},
               new Product{CategoryId=2,ProductId=5,ProductName="Klaviatura",UnitPrice=50,UnitsInStock=190},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }
        public void Delete(Product product)
        {
            Product ProductToDelete = _products.SingleOrDefault(Product => Product.ProductId == product.ProductId);
            if (ProductToDelete != null)
            {
                _products.Remove(ProductToDelete);
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p=>p.CategoryId==categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
           Product ProductToUpdate = _products.SingleOrDefault(product => product.ProductId == product.ProductId);
            if (ProductToUpdate != null)
            {
                ProductToUpdate.ProductId = product.ProductId;
                ProductToUpdate.CategoryId = product.CategoryId;
                ProductToUpdate.ProductName = product.ProductName;
                ProductToUpdate.UnitPrice = product.UnitPrice;
                ProductToUpdate.UnitsInStock = product.UnitsInStock;
            }
           
        }
    }
}
