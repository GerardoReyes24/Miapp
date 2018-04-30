
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.DesignType")]
    [BasedOnRow(typeof(Entities.DesignTypeRow), CheckNames = true)]
    public class DesignTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 DesignTypeId { get; set; }
        [EditLink]
        public String DesType { get; set; }
    }
}