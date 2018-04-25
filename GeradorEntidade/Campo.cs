using ProjetoModeloDDD.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.GeradorEntidade
{
    class Campo
    {
        private bool _IsInt;
        private bool _IsBool;
        private bool _IsString;
        private bool _IsDateTime;
        private bool _IsDate;

        public string Nome { get; set; }
        public string Display { get; set; }
        public bool IsVisivel { get; set; }
        public bool IsOptional { get; set; }
        public int MaxLength { get; set; }
        public int MinLength { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public string MensagemErro { get; set; }
        public string RegularExpression { get; set; }
        public TipoDataType DataType { get; set; }
        public bool IsEmail { get; set; }
        public bool IsCpf { get; set; }
        public bool IsVerdadeiro { get; set; }
        public bool IsUnique { get; set; }

        public bool IsInt
        {
            get
            {
                return _IsInt;
            }
            set
            {
                if (value == true)
                {
                    IsBool = false;
                    IsDate = false;
                    IsDateTime = false;
                    IsString = false;                                        
                }
                _IsInt = value;
            }
        }
        public bool IsBool
        {
            get
            {
                return _IsBool;
            }
            set
            {
                if (value == true)
                {
                    IsInt = false;
                    IsDate = false;
                    IsDateTime = false;
                    IsString = false;
                }
                _IsBool = value;
            }
        }
        public bool IsString
        {
            get
            {
                return _IsString;
            }
            set
            {
                if (value == true)
                {
                    IsInt = false;
                    IsDate = false;
                    IsDateTime = false;
                    IsBool = false;
                }
                _IsString = value;
            }
        }
        public bool IsDateTime
        {
            get
            {
                return _IsDateTime;
            }
            set
            {
                if (value == true)
                {
                    IsInt = false;
                    IsDate = false;
                    IsString = false;
                    IsBool = false;
                }
                _IsDateTime = value;
            }
        }
        public bool IsDate
        {
            get
            {
                return _IsDate;
            }
            set
            {
                if (value == true)
                {
                    IsInt = false;
                    IsDateTime = false;
                    IsString = false;                    
                    IsBool = false;
                }
                _IsDate = value;
            }
        }

        public IList<string> ValidaCampos()
        {
            var erros = new List<string>();
            if (string.IsNullOrEmpty(Nome))            
                erros.Add("Campo Nome é obrigattorio");
            if (!this.IsBool && !this.IsDateTime && !this.IsString && !this.IsInt && !this.IsDate)
                erros.Add("Tipo de dado é obrigatorio");
            if (this.MensagemErro.Length > 60)            
                erros.Add("Erro pode ter no maximo 60 caracteres");            

            return erros;
        }
    }       
}
