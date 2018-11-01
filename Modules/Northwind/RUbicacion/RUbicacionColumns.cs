
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.RUbicacion")]
    [BasedOnRow(typeof(Entities.RUbicacionRow), CheckNames = true)]
    public class RUbicacionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 RUbicacionId { get; set; }
        [EditLink]
        public String RUbicacionN { get; set; }
        public String RUbicacionDesc { get; set; }
    }
}