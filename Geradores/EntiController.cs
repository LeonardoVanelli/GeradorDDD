﻿using Gerador.GeradorEntidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores
{
    class EntiController : GeradorBase
    {
        IList<string> classe = new List<String>();

        public EntiController(string caminho) : base(caminho)
        {
        }

        public void Gerar(string entidade, IList<ForeignKey> TabelasForeignKeys)
        {
            var EMinusculo = entidade.ToLower();
            var EMaiusculo = entidade;            

            classe.Add("using System.Collections.Generic;");
            classe.Add("using System.Web.Mvc;");
            classe.Add("using AutoMapper;");
            classe.Add("using ProjetoModeloDDD.Application.Interface;");
            classe.Add("using ProjetoModeloDDD.Domain.Entities;");
            classe.Add("using ProjetoModeloDDD.MVC.ViewModels;");
            classe.Add("");
            classe.Add("namespace ProjetoModeloDDD.MVC.Controllers");
            classe.Add("{");
            classe.Add("    public class " + EMaiusculo + "sController : Controller");
            classe.Add("    {");
            classe.Add("        private readonly I" + EMaiusculo + "AppService _" + EMinusculo + "App;");
            classe.Add("");
            classe.Add("        public " + EMaiusculo + "sController(I" + EMaiusculo + "AppService " + EMinusculo + "App)");
            classe.Add("        {");
            classe.Add("            _" + EMinusculo + "App = " + EMinusculo + "App;");
            classe.Add("        }");
            classe.Add("");
            classe.Add("        // GET: " + EMaiusculo + "s");
            AddServiceFK(TabelasForeignKeys);
            classe.Add("        public ActionResult Index()");
            classe.Add("        {");
            classe.Add("            var " + EMinusculo + "ViewModel = Mapper.Map<IEnumerable<" + EMaiusculo + ">, IEnumerable<" + EMaiusculo + "ViewModel>>(_" + EMinusculo + "App.GetAll());");
            classe.Add("            return View(" + EMinusculo + "ViewModel);");
            classe.Add("        }");
            classe.Add("");
            classe.Add("        // GET: " + EMaiusculo + "s/Details/5");
            classe.Add("        public ActionResult Details(int id)");
            classe.Add("        {");
            classe.Add("            var " + EMinusculo + " = _" + EMinusculo + "App.GetById(id);");
            classe.Add("            var " + EMinusculo + "ViewModel = Mapper.Map<" + EMaiusculo + ", " + EMaiusculo + "ViewModel>(" + EMinusculo + ");");
            classe.Add("            return View(" + EMinusculo + "ViewModel);");
            classe.Add("        }");
            classe.Add("");
            classe.Add("        // GET: " + EMaiusculo + "s/Create");
            classe.Add("        public ActionResult Create()");
            classe.Add("        {");
            AdicionaForeignKeys(TabelasForeignKeys);
            classe.Add("            return View();");
            classe.Add("        }");
            classe.Add("");
            classe.Add("        // POST: " + EMaiusculo + "s/Create");
            classe.Add("        [HttpPost]");
            classe.Add("        [ValidateAntiForgeryToken]");
            classe.Add("        public ActionResult Create(" + EMaiusculo + "ViewModel " + EMinusculo + ")");
            classe.Add("        {");
            classe.Add("            if (ModelState.IsValid)");
            classe.Add("            {");
            classe.Add("                var " + EMinusculo + "Domain = Mapper.Map<" + EMaiusculo + "ViewModel, " + EMaiusculo + ">(" + EMinusculo + ");");
            classe.Add("                _" + EMinusculo + "App.Add(" + EMinusculo + "Domain);");
            classe.Add("");
            classe.Add("                return RedirectToAction(\"Index\");");
            classe.Add("            }");
            classe.Add("");
            classe.Add("            return View(" + EMinusculo + ");");
            classe.Add("        }");
            classe.Add("");
            classe.Add("        // GET: " + EMaiusculo + "s/Edit/5");
            classe.Add("        public ActionResult Edit(int id)");
            classe.Add("        {");
            classe.Add("            var " + EMinusculo + " = _" + EMinusculo + "App.GetById(id);");
            classe.Add("            var " + EMinusculo + "ViewModel = Mapper.Map<" + EMaiusculo + ", " + EMaiusculo + "ViewModel>(" + EMinusculo + ");");
            classe.Add("");
            classe.Add("            return View(" + EMinusculo + "ViewModel);");
            classe.Add("        }");
            classe.Add("");
            classe.Add("        // POST: " + EMaiusculo + "s/Edit/5");
            classe.Add("        [HttpPost]");
            classe.Add("        [ValidateAntiForgeryToken]");
            classe.Add("        public ActionResult Edit(" + EMaiusculo + "ViewModel " + EMinusculo + ")");
            classe.Add("        {");
            classe.Add("            if (ModelState.IsValid)");
            classe.Add("            {");
            classe.Add("                var " + EMinusculo + "Domain = Mapper.Map<" + EMaiusculo + "ViewModel, " + EMaiusculo + ">(" + EMinusculo + ");");
            classe.Add("                _" + EMinusculo + "App.Update(" + EMinusculo + "Domain);");
            classe.Add("");
            classe.Add("                return RedirectToAction(\"Index\");");
            classe.Add("            }");
            classe.Add("");
            classe.Add("            return View(" + EMinusculo + ");");
            classe.Add("        }");
            classe.Add("");
            classe.Add("        // GET: " + EMaiusculo + "s/Delete/5");
            classe.Add("        public ActionResult Delete(int id)");
            classe.Add("        {");
            classe.Add("            var " + EMinusculo + " = _" + EMinusculo + "App.GetById(id);");
            classe.Add("            var " + EMinusculo + "ViewModel = Mapper.Map<" + EMaiusculo + ", " + EMaiusculo + "ViewModel>(" + EMinusculo + ");");
            classe.Add("");
            classe.Add("            return View(" + EMinusculo + "ViewModel);");
            classe.Add("        }");
            classe.Add("");
            classe.Add("        // POST: " + EMaiusculo + "s/Delete/5");
            classe.Add("        [HttpPost, ActionName(\"Delete\")]");
            classe.Add("        [ValidateAntiForgeryToken]");
            classe.Add("        public ActionResult DeleteConfirmed(int id)");
            classe.Add("        {");
            classe.Add("            var " + EMinusculo + " = _" + EMinusculo + "App.GetById(id);");
            classe.Add("");
            classe.Add("            _" + EMinusculo + "App.Remove(" + EMinusculo + ");");
            classe.Add("");
            classe.Add("            return RedirectToAction(\"Index\");");
            classe.Add("        }");
            classe.Add("    }");
            classe.Add("}");

            var gerado = GerarArquivo(classe);
            SalvarArquivo(gerado, EMaiusculo + "sController", @"PrismaWEB.MVC\Controllers");
        }

        private void AddServiceFK(IList<ForeignKey> tabelasForeignKeys)
        {
            foreach (var tabela in tabelasForeignKeys)
            {
                var tabelaMinusculo = tabela.Tabela.ToLower();
                var tabelaMaiusculo = tabela.Tabela;

                classe.Add($"        private readonly I{tabelaMaiusculo}AppService _{tabelaMinusculo}App;");
            }
            if (tabelasForeignKeys.Count > 0)
                classe.Add("");
        }

        private void AdicionaForeignKeys(IList<ForeignKey> TabelasForeignKeys)
        {
            foreach (var tabela in TabelasForeignKeys)
            {
                var tabelaMinusculo = tabela.Tabela.ToLower();
                var tabelaMaiusculo = tabela.Tabela;
                var campoView = tabela.CampoView;

                classe.Add($"            ViewBag.{tabelaMaiusculo}Id = new SelectList(_{tabelaMinusculo}App.GetAll(), \"Id\", \"{campoView}\");");
            }
        }
    }

}
