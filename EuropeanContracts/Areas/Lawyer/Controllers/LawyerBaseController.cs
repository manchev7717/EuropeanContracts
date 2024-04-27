using EuropeanContracts.Core.ErrorMessageAndConstance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Areas.Lawyer.Controllers
{
    [Area(RoleConstance.AdminArea)]
    [Authorize(Roles = RoleConstance.AdminRole)]
    public class LawyerBaseController : Controller
    {
    }
}
