using ECommerce.Domain.Models;

namespace ECommerce.WebUI.Services;

public interface ICartSessionService
{
    Cart GetCart();
    void SetCart(Cart cart);
}
