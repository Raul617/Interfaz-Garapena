﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WineShop.Services;
using WineShop.Data;
using WineShop.Models;
using WineShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using WineShop.Services;


namespace WineShop.Controllers
{
    public class OrdainduController : Controller
    {
        private readonly ISaskiaService _saskiaService;

        public OrdainduController(ISaskiaService saskiaService)
        {
            _saskiaService = saskiaService;
        }
        public IActionResult Index()
        {
            return View();
        }

        // public OrdainduController(WineShopDbContext
        //context, ISaskiaService saskiaService)
        // {
        //     _context = context;
        //     _saskiaService = saskiaService;
        // }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Abizena,Helbidea,Herrialdea,Hiria,Izena,Postakodea,Telefonoa")]
BezeroaEskaera bezeroaEskaera)
        {
            if (ModelState.IsValid)
            {
                /*Bezeroen datuak gorde*/
                bezeroaEskaera.Erabiltzailea = HttpContext.User.Identity.Name;
                bezeroaEskaera.Data = DateTime.Now;
                await _saskiaService.EskaeraBezeroaGehitu(bezeroaEskaera);
                /*Eskaera gorde*/
                var cart = Saskia.SaskiaLortu(this.HttpContext);
                await _saskiaService.EskaeraSortu(bezeroaEskaera, cart.SaskiaId);
                /*Beste pantaila batera berbideratzen da*/
                return RedirectToAction("Osatu", new
                {
                    bezeroa = bezeroaEskaera.Izena + " " + bezeroaEskaera.Abizena,
                    saskiaId = cart.SaskiaId
                });
            }
            return View(bezeroaEskaera);
        }


        //método para ver la información de los productos comprados (en este caso los vinos)
        public async Task<IActionResult> Osatu(string bezeroa, string saskiaId)
        {
            var osatuViewModel = new OsatuViewModel(); //ViewModel bat erabiliko dugu
            osatuViewModel.SaskiaAleak = await _saskiaService.SaskiaLortuAleak(saskiaId);
            osatuViewModel.SaskiaId = saskiaId;
            osatuViewModel.Bezeroa = bezeroa;
            return View(osatuViewModel);
        }

    }

}
