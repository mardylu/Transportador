﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transportador.Negocio;
using Transportador.Models;
using Transportador.Entidades;

namespace Transportador.Controllers
{
    public class TransportadoraController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {

            TransportadoraFacade negocio = new TransportadoraFacade();

            var tranportador = (from i in negocio.Listar(string.Empty).AsEnumerable()
                                orderby i.Nome
                                select new TransportadoraModels
                                {
                                    Id = i.Id,
                                    Nome = i.Nome,

                                }).ToList<TransportadoraModels>();




            return View(tranportador);

        }

        // GET: Cadastro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cadastro/Create
        public ActionResult Create()
        {
            TransportadoraFacade facade = new TransportadoraFacade();

            TransportadoraModels entity = new TransportadoraModels();

            entity.Classificacao = from i in facade.Listar(string.Empty)
                                   select new ClassificacaoModels()
                                   {
                                       Id = i.Id,
                                       Nome = i.Nome
                                   };

            return View(entity);
        }

        // POST: Cadastro/Create
        [HttpPost]
        public ActionResult Create(TransportadoraModels entity)
        {
            try
            {

                TransportadoraFacade facade = new TransportadoraFacade();
                Transportadora novo = new Transportadora { Nome = entity.Nome };

                facade.Gravar(novo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(entity);
            }
        }

        // GET: Cadastro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cadastro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cadastro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cadastro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
