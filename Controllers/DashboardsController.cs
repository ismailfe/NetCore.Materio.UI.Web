using Microsoft.AspNetCore.Mvc;

namespace NetCore.Materio.UI.Web.Controllers;

public class DashboardsController : Controller
{
    public IActionResult Index() => View();
}
