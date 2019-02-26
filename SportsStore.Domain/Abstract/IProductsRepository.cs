using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using SportsStore.Domain.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Concrete.Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
