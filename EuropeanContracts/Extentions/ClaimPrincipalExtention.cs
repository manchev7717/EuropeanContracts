using EuropeanContracts.Core.ErrorMessageAndConstance;
using System.Security.Claims;

namespace EuropeanContracts.Extentions
{
    public static class ClaimPrincipalExtention
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(RoleConstance.AdminRole);
        }
    }
}
