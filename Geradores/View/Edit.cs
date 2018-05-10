using Gerador.GeradorEntidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores.View
{
    class Edit : GeradorBase
    {
        IList<string> classe = new List<string>();

        public void Gerar(Tabela tabela)
        {
            classe.Add("@model ProjetoModeloDDD.MVC.ViewModels."+tabela.Nome+"ViewModel");
            classe.Add("");
            classe.Add("@{");
            classe.Add("    ViewBag.Title = \"Edit\";");
            classe.Add("}");
            classe.Add("");
            classe.Add("");
            classe.Add("<h2>Edit</h2>");
            classe.Add("");
            classe.Add("@using (Html.BeginForm()) ");
            classe.Add("{");
            classe.Add("    @Html.AntiForgeryToken()");
            classe.Add("");
            classe.Add("    <div class=\"form-group\">");
            classe.Add("        <h4>"+tabela.Nome+"</h4>");
            classe.Add("        <hr />");
            classe.Add("        @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
            classe.Add("        @Html.HiddenFor(model => model." + tabela.Nome + ")");
            classe.Add("");
            AdicionaInputs(tabela);
            classe.Add("        <div class=\"form-group\">");
            classe.Add("            <div class=\"col-md-offset-2 col-md-10\">");
            classe.Add("                <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />");
            classe.Add("            </div>");
            classe.Add("        </div>");
            classe.Add("    </div>");
            classe.Add("}");
            classe.Add("<div>");
            classe.Add("    @Html.ActionLink(\"Back to List\", \"Index\")");
            classe.Add("</div>");
            classe.Add("");
            classe.Add("@section Scripts {");
            classe.Add("    @Scripts.Render(\"~/bundles/jqueryval\")");
            classe.Add("}");
        }

        private void AdicionaInputs(Tabela tabela)
        {
            foreach (var campo in tabela.Campos)
            {
                classe.Add("        <div class=\"form - group\">");
                classe.Add("            @Html.LabelFor(model => model." + campo.Nome + ", htmlAttributes: new { @class = \"control-label col-md-2\" })");
                if (campo.IsBool)
                {
                    classe.Add("                <div class=\"checkbox\">");
                    classe.Add("                    @Html.EditorFor(model => model." + campo.Nome + ")");
                }else if (campo.IsForeignKey)
                {
                    classe.Add("            <div class=\"col-md-10\">");
                    classe.Add("                @Html.DropDownList(\"" + campo.Nome + "\", String.Empty)");
                }
                else
                {
                    classe.Add("            <div class=\"col-md-10\">");
                    classe.Add("                @Html.EditorFor(model => model." + campo.Nome + ", new { htmlAttributes = new { @class = \"form-control\" } })");
                }
                classe.Add("                @Html.ValidationMessageFor(model => model." + campo.Nome + ", \"\", new { @class = \"text-danger\" })");
                classe.Add("            </div>");
                classe.Add("        </div>");
                classe.Add("");
            }
        }
    }
}
