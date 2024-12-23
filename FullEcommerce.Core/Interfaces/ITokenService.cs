using FullEcommerce.Core.Identity;

namespace FullEcommerce.Core.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
