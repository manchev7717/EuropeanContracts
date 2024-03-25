using System.Security.Claims;

namespace EuropeanContracts.Extentions
{
    public static class ClaimPrincipalExtention
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
