using IntroduccionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionMVC.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult indexMultiplicar()
        {
            return View();
        }
        public ActionResult indexDividir()
        {
            return View();
        }
        public ActionResult Suma()
        {
            Datos objmodelo = new Datos();
            objmodelo.variableA = 3;
            objmodelo.variableB = 4;
            objmodelo.resultado = objmodelo.variableA + objmodelo.variableB;
            ViewData["resultado"] = objmodelo.resultado;

            return View();
        }
        public ActionResult Resta()
        {
            Datos objmodelo = new Datos();
            objmodelo.variableA = double.Parse(Request.Form["txtnum1"].ToString());
            objmodelo.variableB= double.Parse(Request.Form["txtnum2"].ToString());
            objmodelo.resultado = objmodelo.variableA - objmodelo.variableB;
            return View("Resta",objmodelo);
        }

        public ActionResult Multi()
        {
            Datos objmodelo = new Datos();
            objmodelo.variableA = double.Parse(Request.Form["txtnum1"].ToString());
            objmodelo.variableB = double.Parse(Request.Form["txtnum2"].ToString());
            objmodelo.resultado = objmodelo.variableA * objmodelo.variableB;
            return View("Multi", objmodelo);
        }
        public ActionResult Divi()
        {
            Datos objmodelo = new Datos();
            objmodelo.variableA = double.Parse(Request.Form["txtnum1"].ToString());
            objmodelo.variableB = double.Parse(Request.Form["txtnum2"].ToString());
            try{
                objmodelo.resultado = objmodelo.variableA / objmodelo.variableB;
            }
            catch( Exception ex)
            {
                
            }
           
            return View("Divi", objmodelo);
        }
    }
}