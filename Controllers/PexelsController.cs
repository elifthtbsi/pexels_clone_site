using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class PexelsController : Controller
{
    public async Task<IActionResult> Index()
    {
        // Pexels API'den görselleri çekme işlemleri burada yapılabilir
        // Örneğin, HomeController'daki Index metodu gibi
        return View();
    }
}
