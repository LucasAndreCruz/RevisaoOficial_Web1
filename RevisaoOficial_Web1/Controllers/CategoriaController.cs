using RevisaoOficial_Web1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RevisaoOficial_Web1.Controllers
{
    public class CategoriaController : Controller
    {

        // Método de List ou Listagem
        public ActionResult Index()
        {
            // Criar Uma lista do Tipo Categoria

            //Passando pela View a lista 
            return View(listaDeCategoria());
        }

        // método que retorne uma lista de categoria populada

        public List<Categoria> listaDeCategoria()
        {
            //Criando os objetos
            Categoria c1 = new Categoria();
            Categoria c2 = new Categoria();
            Categoria c3 = new Categoria();

            // Prenchendo os objetos com valores

            c1.CategoriaId = 1;
            c1.Descricao = "Verduras";

            c2.CategoriaId = 2;
            c2.Descricao = "Frutas";

            c3.CategoriaId = 3;
            c3.Descricao = "Congelados";

            // Criando uma Lista para ser populada com esses objetos

            List<Categoria> listaPopulada = new List<Categoria>();

            // Adicionando os objetos criados na listaPopulada

            listaPopulada.Add(c1);
            listaPopulada.Add(c2);
            listaPopulada.Add(c3);

            // Como é um método que retorna uma lista

            return listaPopulada;

            // Irá retorna essa lista populada com os objetos criado

        }

    }
}