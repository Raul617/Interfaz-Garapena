namespace Wineshop.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using Wineshop.Models;
    using Wineshop.Services;

    public class KarritoViewComponent : ViewComponent
    {
        private readonly ISaskiaService _saskiaService;
        public KarritoViewComponent(ISaskiaService saskiaService)
        {
            _saskiaService = saskiaService;
        }
        public async Task<IViewComponentResult> InvokeAsync(String id) //enseñar lo que queremos ver, en este caso el carrito 
        {

            List<SaskiaAlea> saskialist = await _saskiaService.SaskiaLortuAleak(id); //crear la lista con los valores
            ViewBag.saskiacount = saskialist.Count();//contar los registros
            return View();
        }
    }
}
