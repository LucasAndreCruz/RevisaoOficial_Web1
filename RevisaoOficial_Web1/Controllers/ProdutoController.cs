using RevisaoOficial_Web1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RevisaoOficial_Web1.Controllers
{
    public class ProdutoController : Controller
    {
        // Método de List ou Listagem
        public ActionResult Index()
        {
            // Criar Uma lista do Tipo Categoria

            List<Produto> listaDeProduto = new List<Produto>();

            //Passando pela View a lista 
            return View(listaDeProduto);
        }

        // Método Create ou Cadastro

        public ActionResult Create()
        {
            // Criando uma instacia de categoriaControler
            // Para que consiga acessar a lista de categorias

            CategoriaController categorias = new CategoriaController();

            // Criando a variavel View BAG

            ViewBag.CategoriaId = new SelectList(categorias.listaDeCategoria(), "CategoriaId", "Descricao");

            return View();
        }


    }
}