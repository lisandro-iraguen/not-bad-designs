using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;

namespace Api;

public interface IProductData
{
    Task<Product> AddProduct(Product product);
    Task<bool> DeleteProduct(int id);
    Task<IEnumerable<Product>> GetProducts();
    Task<Product> UpdateProduct(Product product);
}

public class ProductData : IProductData
{
    private readonly List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name= "SIHST",
                Description= "Pagina Web de Seguridad e Higiene",
                Url="https://sihst-638fd.firebaseapp.com/",
                Image="data/images/sihst.png"
            },
         
        };

    public Task<Product> AddProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetProducts()
    {
        return Task.FromResult(products.AsEnumerable());
    }

    public Task<Product> UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}
