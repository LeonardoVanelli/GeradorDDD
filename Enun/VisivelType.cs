using System;

namespace Gerador.Enun
{
    [Flags]
    public enum VisivelType
    {
        Nenhum = 0,
        Grid = 1,
        Form = 2,
        Details = 4,
        Edit = 8,       
        
        Todos = Grid + Form + Details + Edit
    }    
}
