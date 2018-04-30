
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.Priority")]
    [BasedOnRow(typeof(Entities.PriorityRow), CheckNames = true)]
    public class PriorityColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 PriorityId { get; set; }
        [EditLink]
        public String PriorityDescription { get; set; }
    }
}