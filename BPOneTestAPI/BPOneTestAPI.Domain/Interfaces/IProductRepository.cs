﻿using BPOneTestAPI.Domain.Entities;

namespace BPOneTestAPI.Domain.Interfaces
{
	public interface IProductRepository
	{
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetByIdAsync(int? id);
        Task<Product> GetProductByCategoryIdAsync(int? id);
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> RemoveAsync(Product product);
    }
}
