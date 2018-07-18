using Gerador.Enun;
using Gerador.GeradorEntidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores.View
{
    class Create : GeradorBase
    {
        IList<string> classe = new List<String>();

        public Create(string caminho) : base(caminho)
        {
        }

        public void Gerar(Tabela tabela)
        {
            classe.Add("@model ProjetoModeloDDD.MVC.ViewModels."+tabela.Nome+"ViewModel");
            classe.Add("");
            classe.Add("@{");
            classe.Add("    ViewBag.Title = \"Create\";");
            classe.Add("}");
            classe.Add("");
            classe.Add("<h2>Create</h2>");
            classe.Add("");
            classe.Add("@using (Html.BeginForm()) ");
            classe.Add("{");
            classe.Add("    @Html.AntiForgeryToken()");
            classe.Add("");
            classe.Add("    <div class=\"form-horizontal\">");
            classe.Add("        <h4>ClienteViewModel</h4>");
            classe.Add("        <hr />");
            classe.Add("        @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
            AdicionaCampo(tabela);
            classe.Add("        <div class=\"form-group\">");
            classe.Add("            <div class=\"col-md-offset-2 col-md-10\">");
            classe.Add("                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />");
            classe.Add("            </div>");
            classe.Add("        </div>");
            classe.Add("    </div>");
            classe.Add("}");
            classe.Add("");
            classe.Add("<div>");
            classe.Add("    @Html.ActionLink(\"Back to List\", \"Index\")");
            classe.Add("</div>");
            classe.Add("");
            classe.Add("@section Scripts {");
            classe.Add("    @Scripts.Render(\"~/bundles/jqueryval\")");
            classe.Add("}");

            var gerado = GerarArquivo(classe);
        }

        private void AdicionaCampo(Tabela tabela)
        {
            foreach (var campo in tabela.Campos)
            {
                if (campo.VisivelTypes.HasFlag(VisivelType.Form))
                {
                    classe.Add("        <div class=\"form - group\">");
                    classe.Add("            @Html.LabelFor(model => model."+campo.Nome+", htmlAttributes: new { @class = \"control-label col-md-2\" })");
                    classe.Add("            <div class=\"col-md-10\">");
                    if (campo.IsBool)
                        classe.Add("                    @Html.EditorFor(model => model." + campo.Nome + ")");
                    else if (campo.IsForeignKey)
                        classe.Add("                @Html.DropDownList(\"" + campo.Nome + "\", String.Empty)");
                    else
                        classe.Add("                @Html.EditorFor(model => model." + campo.Nome + ", new { htmlAttributes = new { @class = \"form-control\" } })");

                    classe.Add("                @Html.ValidationMessageFor(model => model."+campo.Nome+", \"\", new { @class = \"text-danger\" })");
                    classe.Add("            </div>");
                    classe.Add("        </div>");
                    classe.Add("");
                }
            }
        }
    }
}
