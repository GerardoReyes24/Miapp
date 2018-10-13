
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.TipoMueble")]
    [BasedOnRow(typeof(Entities.TipoMuebleRow), CheckNames = true)]
    public class TipoMuebleColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 TipoMuebleId { get; set; }
        [EditLink]
        public String MuebleName { get; set; }
        public String MuebleDescription { get; set; }
    }
}