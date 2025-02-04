using ECommerce.Domain.Entities;
using ECommerce.Domain.Models;

namespace ECommerce.Application.Abstract;

public interface ICartService
{
    void AddToCart(Cart cart , Product product);
    void RemoveFromCart(Cart cart , int productId);
    List<CartLine> List(Cart cart);
}