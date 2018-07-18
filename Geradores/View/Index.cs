using Gerador.Enun;
using Gerador.GeradorEntidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores.View
{
    class Index : GeradorBase
    {
        IList<string> classe = new List<String>();

        public Index(string caminho) : base(caminho)
        {
        }

        public void Gerar(Tabela tabela)
        {
            classe.Add("@model IEnumerable<ProjetoModeloDDD.MVC.ViewModels." + tabela.Nome + "ViewModel>");
            classe.Add("");
            classe.Add("@{");
            classe.Add("    ViewBag.Title = \"Index\";");
            classe.Add("}");
            classe.Add("");
            classe.Add("<h2>Index</h2>");
            classe.Add("");
            classe.Add("<p>");
            classe.Add("    @Html.ActionLink(\"Create New\", \"Create\")");
            classe.Add("</p>");
            classe.Add("<table class=\"table\">");
            classe.Add("    <tr>");
            AddCamposCabecalho(tabela);
            classe.Add("        <th></th>");
            classe.Add("    </tr>");
            classe.Add("");
            classe.Add("@foreach (var item in Model) {");
            classe.Add("    <tr>");
            AddCamposCorpo(tabela);
            classe.Add("        <td>");
            classe.Add("            @Html.ActionLink(\"Edit\", \"Edit\", new { /* id=item.PrimaryKey */ }) |");
            classe.Add("            @Html.ActionLink(\"Details\", \"Details\", new { /* id=item.PrimaryKey */ }) |");
            classe.Add("            @Html.ActionLink(\"Delete\", \"Delete\", new { /* id=item.PrimaryKey */ })");
            classe.Add("        </td>");
            classe.Add("    </tr>");
            classe.Add("}");
            classe.Add("");
            classe.Add("</table>");

            var gerado = GerarArquivo(classe);
        }

        private void AddCamposCorpo(Tabela tabela)
        {
            foreach (var campo in tabela.Campos)
            {
                if (campo.VisivelTypes == VisivelType.Grid || campo.VisivelTypes == VisivelType.Todos)
                {
                    classe.Add("        <td>");
                    if (campo.IsForeignKey)
                        classe.Add("            @Html.DisplayFor(modelItem => item."+campo.ForeignKey.Tabela+"."+campo.ForeignKey.CampoView+")");
                    else
                        classe.Add("            @Html.DisplayFor(modelItem => item." + campo.Nome + ")");
                    classe.Add("        <td>");
                }
            }
        }

        private void AddCamposCabecalho(Tabela tabela)
        {
            foreach (var campo in tabela.Campos)
            {
                if (campo.VisivelTypes == VisivelType.Grid || campo.VisivelTypes == VisivelType.Todos)
                {

                    classe.Add("        <th>");
                    if (campo.IsForeignKey)
                        classe.Add("            @Html.DisplayNameFor(model => model." + campo.Nome + ")");
                    else
                        classe.Add("            @Html.DisplayNameFor(model => model." + campo.Nome + ")");
                    classe.Add("        <th>");

                }
            }
        }
    }
}
