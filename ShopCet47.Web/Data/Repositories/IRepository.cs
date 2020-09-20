using System.Collections.Generic;
using System.Threading.Tasks;
using ShopCet47.Web.Data.Entities;

namespace ShopCet47.Web.Data.Repositories
{
    public interface IRepository
    {
        void AddProduct(Product product);

        Product GetProduct(int id);

        IEnumerable<Product> GetProducts();

        bool ProductExists(int id);

        void RemoveProduct(Product product);

        Task<bool> SaveAllAsync();

        void UpdateProduct(Product product);
    }
}