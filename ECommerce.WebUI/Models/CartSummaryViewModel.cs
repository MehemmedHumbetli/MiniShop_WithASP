using ECommerce.Domain.Models;

namespace ECommerce.WebUI;

public class CartSummaryViewModel
{
    public CartSummaryViewModel()
    {
    }

    public Cart Cart { get; set; }
}