
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.ProductionSt")]
    [BasedOnRow(typeof(Entities.ProductionStRow), CheckNames = true)]
    public class ProductionStColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProductionStId { get; set; }
        public Int32 DetailId { get; set; }
        public Int32 Cutter { get; set; }
        public Int32 Cnc { get; set; }
        public Int32 Plating { get; set; }
        public Int32 Armed { get; set; }
        public Int32 Packed { get; set; }
    }
}