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
                Name= "test",
                Description= "Never Forgive, Never Forget Classic T-Shirt",
                Price="23.34$",
                Url="https://www.redbubble.com/i/t-shirt/Never-Forgive-Never-Forget-by-NotBadDesigns/144902526.WFLAH",
                Image="data/images/image (8).jpg"
            },
		     new Product
			{
				Id = 2,
				Name= "test",
				Description= "test",
				Url="https://www.google.com.ar",
				Image="data/images/image (2).jpg"
			}, 
			new Product
			{
				Id = 3,
				Name= "test",
				Description= "test",
				Url="https://www.google.com.ar",
				Price="100$",
				Image="data/images/image (3).jpg"
			},  
			new Product
			{
				Id = 4,
				Name= "test",
				Description= "test",
				Url="https://www.google.com.ar",
				Price="100$",
				Image="data/images/image (4).jpg"
			},  
			new Product
			{
				Id = 5,
				Name= "test",
				Description= "test",
				Price="100$",
				Url="https://www.google.com.ar",
				Image="data/images/image (5).jpg"
			},
			new Product
			{
				Id = 6,
				Name= "test",
				Description= "test",
				Price="100$",
				Url="https://www.google.com.ar",
				Image="data/images/image (6).jpg"
			},
			new Product
			{
				Id = 6,
				Name= "test",
				Description= "test",
				Price="100$",
				Url="https://www.google.com.ar",
				Image="data/images/image (6).jpg"
			},
			new Product
			{
				Id = 7,
				Name= "test",
				Description= "test",
				Price="100$",
				Url="https://www.google.com.ar",
				Image="data/images/image (7).jpg"
			},
			new Product
			{
				Id = 8,
				Name= "test",
				Description= "test",
				Price="100$",
				Url="https://www.google.com.ar",
				Image="data/images/image (8).jpg"
			}
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
