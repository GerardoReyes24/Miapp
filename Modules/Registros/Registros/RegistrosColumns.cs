
namespace Miapp2.Registros.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Registros.Registros")]
    [BasedOnRow(typeof(Entities.RegistrosRow), CheckNames = true)]
    public class RegistrosColumns
    {
      
        public DateTime Fecha { get; set; }
        [EditLink]
        public String ProductProductName { get; set; }
        [Width(200)]
        public Decimal Cantidad { get; set; }
        [Width(200)]
        public Int32 Movimiento { get; set; }
        public String NoOrden { get; set; }
        [QuickFilter]
        public String ProyectorProyectorName { get; set; }
        [QuickFilter]
        public String TipoMuebleMuebleName { get; set; }
        [QuickFilter]
        public String NoCasaNumeroCasa { get; set; }
    }
}