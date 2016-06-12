using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductStore.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;

        public ProductRepository()
        {
            Add(new Product { Name = "Nano", Category = "Cars", Price = 2.39M });
            Add(new Product { Name = "Safari", Category = "Cars", Price = 10.75M });
            Add(new Product { Name = "Ace", Category = "Trucks", Price = 3.75M });
            Add(new Product { Name = "Winger", Category = "Passenger", Price = 8.75M });
            Add(new Product { Name = "Zica", Category = "Cars", Price = 4.75M });
            Add(new Product { Name = "Prima", Category = "Trucks", Price =40.75M });
            Add(new Product { Name = "Xenon Pickup", Category = "Cars", Price = 5.75M });
            Add(new Product { Name = "Indica", Category = "Cars", Price = 5.99M });
            Add(new Product { Name = "Magic", Category = "Passenger", Price = 3.25M });
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            item.Id = _nextId++;
            products.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            products.RemoveAll(p => p.Id == id);
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(item);
            return true;
        }
    }
}