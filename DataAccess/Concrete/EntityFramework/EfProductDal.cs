using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NtierDbContext context=new NtierDbContext())
            {
                var addedEntity=context.Entry(entity);
                addedEntity.State=EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NtierDbContext context = new NtierDbContext())
            {
                var deletedEntity=context.Entry(entity);
                deletedEntity.State=EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NtierDbContext context = new NtierDbContext())
            {
               return context.Products.ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NtierDbContext context=new NtierDbContext())
            {
                var updatedEntity=context.Entry(entity);
                updatedEntity.State=EntityState.Modified;
                context.SaveChanges();
            }


        }
    }
}
