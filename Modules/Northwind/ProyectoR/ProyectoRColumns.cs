
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.ProyectoR")]
    [BasedOnRow(typeof(Entities.ProyectoRRow), CheckNames = true)]
    public class ProyectoRColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProyectorId { get; set; }
        [EditLink]
        public String ProyectorName { get; set; }
        public String Description { get; set; }
    }
}