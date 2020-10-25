﻿using ShopCet47.Web.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCet47.Web.Data.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrderAsync(string username);

    }
}
