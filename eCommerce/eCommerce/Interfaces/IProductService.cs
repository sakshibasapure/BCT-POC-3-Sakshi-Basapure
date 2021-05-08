using eCommerce.Dto;
using eCommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCommerce.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Task<int> AddProduct(Product product);
        Task UpdateProduct(Product product);
        Product GetProductData(int productId);
        Task<int> DeleteProduct(int productId);
        List<Categories> GetCategories();
        List<Product> GetSimilarProducts(int productId);
        List<CartItemDto> GetProductsAvailableInCart(string cartId);
        List<Product> GetProductsAvailableInWishlist(string wishlistID);
       
    }
}
