﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleX.Core.Facade;
using SimpleX.Model;
using SimpleX.ModelCore;
using SimpleX.Core;

namespace Simplex.Pizzaria.Areas.Produto.Controllers
{
    public class ProdutoController : Controller
    {
        cadastroFacade facadeProduto;
        cadastroGeralFacade cadastroGeralFacade;

        // GET: Produto/Produto
        public ActionResult index()
        {
            produto produto = new produto();
            produto.produtoCategoria = new produtoCategoria();
            produto.produtoTipo = new produtoTipo();
            return View(produto);
        }

        //Listagens============================================================================================

        public ActionResult produtoListagem()
        {
            return View();
        }

        public PartialViewResult partialProdutoListagem(string pesquisarproduto)
        {
            facadeProduto = new cadastroFacade();
            produto produto = new produto();
            produto.nome = pesquisarproduto;
            //produto.empresaID = Guid.Parse("fc70ecab-61b8-4e53-9a99-6098b0a75a02");
            List<produto> lstProduto = facadeProduto.FiltrarProduto(produto);

            return PartialView(lstProduto);
        }

        //Cadastros============================================================================================

        public ActionResult produtoCadastro()
        {
            List<SelectListItem> itens = new List<SelectListItem>();
            facadeProduto = new cadastroFacade();

            List<produtoCategoria> lstProdutoCategoria = facadeProduto.ListarProdutoCategoria();

            for (int i = 0; i < lstProdutoCategoria.Count; i++)
            {
                itens.Add(new SelectListItem { Value = lstProdutoCategoria[i].ID.ToString(), Text = lstProdutoCategoria[i].nome });
            }

            @ViewBag.produtoCategorias = itens;
            itens = new List<SelectListItem>();

            List<produtoTipo> lstProdutoTipo = facadeProduto.ListarProdutoTipo();

            for (int i = 0; i < lstProdutoTipo.Count; i++)
            {
                itens.Add(new SelectListItem { Value = lstProdutoTipo[i].ID.ToString(), Text = lstProdutoTipo[i].nome });
            }

            @ViewBag.produtoTipos = itens;

            produto produto = new produto();
            produto.produtoCategoria = new produtoCategoria();
            produto.produtoTipo = new produtoTipo();

            return View(produto);
        }

        public ActionResult produtoCadastroEdicao(string idProduto = "")
        {
            List<SelectListItem> itens = new List<SelectListItem>();
            cadastroGeralFacade = new cadastroGeralFacade();
            facadeProduto = new cadastroFacade();


            List<produtoCategoria> lstProdutoCategoria = facadeProduto.ListarProdutoCategoria();

            for (int i = 0; i < lstProdutoCategoria.Count; i++)
            {
                itens.Add(new SelectListItem { Value = lstProdutoCategoria[i].ID.ToString(), Text = lstProdutoCategoria[i].nome });
            }

            @ViewBag.produtoCategorias = itens;
            itens = new List<SelectListItem>();

            List<produtoTipo> lstProdutoTipo = facadeProduto.ListarProdutoTipo();

            for (int i = 0; i < lstProdutoTipo.Count; i++)
            {
                itens.Add(new SelectListItem { Value = lstProdutoTipo[i].ID.ToString(), Text = lstProdutoTipo[i].nome });
            }

            @ViewBag.produtoTipos = itens;

            produto produto = new SimpleX.Model.produto();
            if (idProduto != "")
            {
                produto = facadeProduto.ConsultarProduto(Guid.Parse(idProduto));
            }


            return View("produtoCadastro", produto);
        }

        //Salvar============================================================================================
        [HttpPost]
        public ActionResult SalvarProduto(produto produto)
        {
            facadeProduto = new cadastroFacade();
            Result resultado = facadeProduto.SalvarProduto(produto);
            if (produto.ID != Guid.Empty)
            {
                resultado.AddMensagem("ID", produto.ID.ToString());
                resultado.Sucesso = true;
            }

            return Json(resultado);
        }

        //Excluir============================================================================================
        public ActionResult ExcluirProduto(string idProduto = "")
        {
            facadeProduto = new cadastroFacade();
            Result resultado = new Result();

            if (idProduto != "")
            {
                resultado = facadeProduto.ExcluirProduto(Guid.Parse(idProduto));
            }
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

    }
}