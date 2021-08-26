using Daren.Baker.Bjss.Assignment.Domain.Entities;
using Daren.Baker.Bjss.Assignment.Infrastructure.Providers;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daren.Baker.Bjss.Assignment.Infrastructure.Services
{
    internal class ProductService : IProductService
    {
        private readonly IJsonFileProvider<List<Product>> _provider;
        private readonly string _section = "Products";
        private readonly string _file = "Products.json";

        public ProductService(IJsonFileProvider<List<Product>> provider)
        {
            _provider = provider;
        }

        public IQueryable<Product> GetProducts()
        {
            return _provider.Get(_file, _section).AsQueryable();
        }
    }
}
