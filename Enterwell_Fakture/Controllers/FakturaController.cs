﻿using Enterwell_Fakture.Interfaces;
using Enterwell_Fakture.Models;
using Enterwell_Fakture.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enterwell_Fakture.Controllers
{
    [Authorize]
    public class FakturaController : Controller
    {
        FakturaDbContex _db = new FakturaDbContex();

        [ImportMany]
        IEnumerable<Lazy<IPluginOperation, ICountryName>> _taxes;

        List<string> popis = new List<string>();


    // GET: Faktura
    public ActionResult Index()
        {
            List<Faktura> all = _db.Fakture.ToList();

            return View(all);
        }

        public ActionResult Create()
        {
            foreach (var item in _taxes)
            {
                popis.Add(item.Metadata.Symbol);
            }

            ViewBag.Drzave = popis;

            return View( new  Faktura() );
        }

        [HttpPost]
        public ActionResult Create(Faktura faktura , Stavka stavka,  string btn, string Drzava )
        {
            foreach (var item in _taxes)
            {
                popis.Add(item.Metadata.Symbol);
            }

            ViewBag.Drzave = popis;

            if (btn == "Dodaj stavku +")
            {
                if((stavka.Opis != null) && (stavka.Cijena != 0) && (stavka.Kolicina != 0)) faktura.Stavke.Add(stavka);

                return View("Create" , faktura);
            }
            else if(btn == "Kreiraj fakturu")
            {
                if (faktura.Kupac != null && faktura.Prodavac != null && faktura.Stavke.Count != 0)
                {
                    foreach (var item in _taxes)
                    {
                        if (item.Metadata.Symbol.Equals(Drzava)) faktura.CijenaPDV = item.Value.Calculation((double)faktura.CijenaBezPdv()); 
                    }

                    _db.Fakture.Add(faktura);
                    _db.SaveChanges();

                    return RedirectToAction("Index");
                }

                return View("Create" , faktura);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}