
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.NoCasa")]
    [BasedOnRow(typeof(Entities.NoCasaRow), CheckNames = true)]
    public class NoCasaColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 NoCasaId { get; set; }
        [EditLink]
        public String NumeroCasa { get; set; }
    }
}