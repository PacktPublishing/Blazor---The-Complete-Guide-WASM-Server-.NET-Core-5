using Microsoft.AspNetCore.Identity;

namespace DataAcesss.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
