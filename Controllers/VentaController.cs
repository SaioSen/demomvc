using Microsoft.AspNetCore.Mvc;
using demomvc.Models;


namespace demomvc.Controllers
{
    public class VentaController:Controller
    {
        
        public IActionResult Index()
        {
            return View();

        }

         public IActionResult Calcular(Venta objventa)
        {
            decimal subtotal=0;
            decimal total=0;
            ViewData["Message"]="Sin resultado";
            if(objventa.Cantidad>0){
                if(objventa.Precio>0){
                    subtotal = objventa.Precio * objventa.Cantidad;
                    total= subtotal *1.18m;
                    ViewData["Message"]="El subtotal es: "+subtotal+"\n El total es: "+ total;
                }else{
                ViewData["Message"] = "El precio debe ser mayor que 0";
            }

                }else{
                ViewData["Message"] = "La cantidad debe ser mayor que 0";
            }
            return View("Index");
        }

    }
}