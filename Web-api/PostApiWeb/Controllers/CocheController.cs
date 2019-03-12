using PostApiWeb.Models;
using PostApiWeb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PostApiWeb.Controllers
{
    public class CocheController : ApiController
    {
        RepositoryCoche repo;
        public CocheController() {
            repo = new RepositoryCoche();
        }

        public List<Coche> Get() {
            return repo.getCoches();
        }
        public Coche Get(int id)
        {
            return repo.getCoche(id);
        }
        public String Post(Coche c)
        {
             repo.AddCoche(c);
            return "Coche Añadido";
        }
        public String Put(Coche c)
        {
            repo.EditCoche(c);
            return "Coche Modificado";
        }
        public String Delete(int c)
        {
            repo.RemoveCoche(c);
            return "Coche Eliminado";
        }
    }
}
