
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
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 RegistroId { get; set; }
        public DateTime Fecha { get; set; }
        [EditLink]
        public String ProductProductName { get; set; }
        public Decimal Cantidad { get; set; }
        public Int32 Movimiento { get; set; }

        [DisplayName("Mueble")]
        public String DesignTypeId { get; set; }


        [DisplayName("Proyecto")]
        public String ProjectName { get; set; }
    }
}