using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Miapp2.Northwind.Entities
{
    [EnumKey("ProductionSt.Status")]
    public enum ProdStatus
    {
        [Description("Empezado")]
        Empezado = 1,
        [Description("En proceso")]
        EnProceso = 2,
        [Description("Terminado")]
        Terminado = 3
    }
}
