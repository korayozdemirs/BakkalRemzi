using BakkalRemzi.DAL;
using BakkalRemzi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkalRemzi.BLL
{
    public class ProductRepository : IRepository<Product>
    {
        BakkalRemziEntities db = new BakkalRemziEntities();
        public void Add(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Product entity)
        {
            db.Products.Remove(entity);
            db.SaveChanges();
        }

        public List<Product> getAll()
        {
            return db.Products.ToList();
        }

        public Product selectById(int Id)
        {
            return db.Products.FirstOrDefault(z => z.Id == Id);
        }

        public void Update(Product entity)
        {
            Product selectedProduct = db.Products.FirstOrDefault(z => z.Id == entity.Id);
            selectedProduct.Name = entity.Name;
            selectedProduct.Price = entity.Price;
            selectedProduct.Stock = entity.Stock;
            db.SaveChanges();
        }
    }
}
