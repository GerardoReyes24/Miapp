using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Miapp2.Registros.Endpoints
{
    [EnumKey("Registros.TipoMOvimiento")]
    public enum TipoMovimiento
    {
        [Description("Entrada")]
        Entrada = 1,
        [Description("Salida")]
        Salida = 2,
      
    }
}
