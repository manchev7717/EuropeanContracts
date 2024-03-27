using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Controllers.Base
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
