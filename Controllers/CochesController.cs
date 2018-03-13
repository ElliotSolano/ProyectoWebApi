using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    
    public class CochesController : ApiController
    {
        List<Coche> listaCoches = new List<Coche>();
        public CochesController()
        {
            Coche c = new Coche { idCoche = 1, Marca = "Ferrari", Modelo = "F40" };
            listaCoches.Add(c);

            c = new Coche { idCoche = 2, Marca = "Ford", Modelo = "GT500" };
            listaCoches.Add(c);

            c = new Coche { idCoche = 3, Marca = "Toyota", Modelo = "Supra" };
            listaCoches.Add(c);
        }

        public List<Coche> GetCoches()
        {
            return listaCoches;
        }

        public Coche GetCoche(int id)
        {
            return listaCoches.Where(t => t.idCoche == id).FirstOrDefault();
        }
    }
}
