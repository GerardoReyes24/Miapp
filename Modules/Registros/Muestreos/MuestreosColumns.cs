
namespace Miapp2.Registros.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Registros.Muestreos")]
    [BasedOnRow(typeof(Entities.MuestreosRow), CheckNames = true)]
    public class MuestreosColumns
    {
       
        public DateTime Fecha { get; set; }
        [EditLink, DisplayName("Material muestreado"), Width(380)]
        public String ProductProductName { get; set; }
        [DisplayName("Cantidad contada"), Width(200)]
        public Decimal CantidadAMuestrear { get; set; }
        [DisplayName("Desviaciones"), Width(200)]
        public Decimal CantidadContada { get; set; }
       [Width(200), DisplayFormat("'$'+#,##0.00")]
        public Decimal DesviacionEconomica { get; set; }
    }
}