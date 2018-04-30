
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.ProjectDetails")]
    [BasedOnRow(typeof(Entities.ProjectDetailsRow), CheckNames = true)]
    public class ProjectDetailsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]


        public String DesignType { get; set; }
        public Decimal Width { get; set; }
        public Decimal High { get; set; }

        public Decimal Deep { get; set; }


        public String Observaciones { get; set; }
    }
}