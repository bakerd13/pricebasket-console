using Daren.Baker.Bjss.Assignment.Domain.Entities;
using System.Linq;

namespace Daren.Baker.Bjss.Assignment.Infrastructure.Services
{
    public interface IProductService
    {
        /// <summary>
        /// Get Products
        /// </summary>
        /// <returns>A List of products</returns>
        IQueryable<Product> GetProducts();
    }
}
