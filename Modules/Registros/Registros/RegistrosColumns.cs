
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
        [DisplayName("Material")]
        public String ProductProductName { get; set; }
        public Decimal Cantidad { get; set; }
        [Width(140)]
        public Int32 Movimiento { get; set; }
        [DisplayName("Numero de Orden")]
        public String NoOrder { get; set; }


        [DisplayName("Mueble")]
        public String DesignTypeId { get; set; }


        [DisplayName("Proyecto")]
        public String ProjectName { get; set; }
    }
}