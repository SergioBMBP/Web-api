using PostApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostApiWeb.Repositories
{
    public class RepositoryCoche
    {
        CochesContext context;
        public RepositoryCoche()
        {
            context = new CochesContext();
        }

        public List<Coche> getCoches()
        {
            return context.Coches.ToList();
        }

        public Coche getCoche(int id)
        {
            return context.Coches.Where(z => z.Idcoche == id).FirstOrDefault();
        }
        public void AddCoche(Coche Car)
        {
            context.Coches.Add(Car);
            context.SaveChanges();
        }
        public void RemoveCoche(int c)
        {
            Coche car = context.Coches.Where(z => z.Idcoche == c).FirstOrDefault();
            context.Coches.Remove(car);
            context.SaveChanges();
        }
        public void EditCoche(Coche Car)
        {
            var con = getCoche(Car.Idcoche);
            con.Marca = Car.Marca;
            con.Modelo = Car.Modelo;
            con.Color = Car.Color;
            context.SaveChanges();
        }

    }
}