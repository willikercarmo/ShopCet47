using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopCet47.Web.Data.Entities;
using ShopCet47.Web.Helpers;

namespace ShopCet47.Web.Data.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public OrderRepository(DataContext context, IUserHelper userHelper) : base(context)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string username)
        {
            var user = await _userHelper.GetUserByEmailAsync(username);
            if (user == null)
            {
                return null;
            }

            return _context.OrderDetailTemps
               .Include(o => o.Product) // traz os produtos
               .Where(o => o.User == user) // seleciona o user que está logado
               .OrderBy(o => o.Product.Name); // ordena por nome
        }

        public async Task<IQueryable<Order>> GetOrderAsync(string username)
        {
            var user = await _userHelper.GetUserByEmailAsync(username);
            if (user == null)
            {
                return null;
            }

            if (await _userHelper.IsUserInRoleAsync(user, "Admin"))
            {
                // se o user for o admin
                return _context.Orders
                .Include(o => o.Items) // traz os items
                .ThenInclude(i => i.Product) // traz os produtos la dentro
                .OrderByDescending(o => o.OrderDate); // ordena por ordem da data

            }

            //se não for admin
            return _context.Orders
                .Include(o => o.Items) // traz os items
                .ThenInclude(i => i.Product) // traz os produtos la dentro
                .Where(o => o.User == user) // do user
                .OrderByDescending(o => o.OrderDate); // ordena por ordem da data
        }
    }
}
