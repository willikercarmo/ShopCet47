﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopCet47.Web.Data.Entities;

namespace ShopCet47.Web.Data.Repositories
{
    //Usei só para teste

    public class TesteRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Um", Price = 10 });
            products.Add(new Product { Id = 2, Name = "Dpis", Price = 20 });
            products.Add(new Product { Id = 3, Name = "Três", Price = 30 });
            products.Add(new Product { Id = 4, Name = "Quatro", Price = 40 });
            products.Add(new Product { Id = 5, Name = "Cinco", Price = 50 });
            products.Add(new Product { Id = 6, Name = "Seis", Price = 60 });

            return products;
        }

        public bool ProductExists(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
