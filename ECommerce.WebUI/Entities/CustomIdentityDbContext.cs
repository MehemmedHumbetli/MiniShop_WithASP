using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.WebUI.Entities
{
    public class CustomIdentityDbContext(DbContextOptions<CustomIdentityDbContext> options) : IdentityDbContext<CustomIdentityUser, CustomIdentityRole, string>(options)
    {
    }
}
