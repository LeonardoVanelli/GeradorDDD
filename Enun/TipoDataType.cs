using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Enum
{
    public class TipoDataType : Enumeration
    {

        public static TipoDataType Password = new TipoDataType(0, "Password");
        public static TipoDataType Input     = new TipoDataType(1, "Input");       

        protected TipoDataType()
        {        
        }

        protected TipoDataType(int id, string name)
            : base(id, name)
        {
        }

        public static IEnumerable<TipoDataType> List()
        {
            return new[] { Password, Input };
        }

        public static TipoDataType GetById(int id)
        {
            if (id == 0)
            {
                return TipoDataType.Password;
            }
            else if (id == 1)
            {
                return TipoDataType.Input;
            }
            else
                return null;
        }
    }
}
