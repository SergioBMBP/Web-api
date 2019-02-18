using PostApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostApiWeb.Repositories
{
    public class RepositoryCoche
    {
        List<Coche> Listacoches;
        public RepositoryCoche() {
            Listacoches = new List<Coche>();
            Coche c1 = new Coche()
            {
                Idcoche = 1,
                Marca = "Opel",
                Modelo = "Insignia",
                Color = "Blanco"
            };
            Listacoches.Add(c1);
            Coche c2 = new Coche()
            {
                Idcoche = 2,
                Marca = "Seat",
                Modelo = "Leon",
                Color = "Rojo"
            };
            Listacoches.Add(c2);
            Coche c3 = new Coche()
            {
                Idcoche = 3,
                Marca = "BMW",
                Modelo = "X1",
                Color = "Negro"
            };
            Listacoches.Add(c3);
            Coche c4 = new Coche()
            {
                Idcoche = 4,
                Marca = "Audi",
                Modelo = "Q3",
                Color = "Gris"
            };
            Listacoches.Add(c4);

        }

        public List<Coche> getCoches() {
            return Listacoches;
        }

        public Coche getCoche( int id)
        {
            return Listacoches.Find(z=>z.Idcoche==id);
        }
    }
}