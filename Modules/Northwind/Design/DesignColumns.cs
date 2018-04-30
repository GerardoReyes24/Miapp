
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.Design")]
    [BasedOnRow(typeof(Entities.DesignRow), CheckNames = true)]
    public class DesignColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 DesignId { get; set; }
        public DateTime Date { get; set; }
        public String DesignTypeDesType { get; set; }
        public Decimal DesignTime { get; set; }
        public Boolean DesignInTime { get; set; }
        public Boolean Aproved { get; set; }
    }
}