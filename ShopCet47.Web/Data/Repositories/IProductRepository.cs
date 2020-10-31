using Microsoft.AspNetCore.Mvc.Rendering;
using ShopCet47.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCet47.Web.Data.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<SelectListItem> GetComboProducts(); // agarra nos produtos e coloca na lista


    }
}
