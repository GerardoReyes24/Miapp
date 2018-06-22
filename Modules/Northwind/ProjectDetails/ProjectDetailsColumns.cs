
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Miapp2.Northwind.Entities;

    [ColumnsScript("Northwind.ProjectDetails")]
    [BasedOnRow(typeof(Entities.ProjectDetailsRow), CheckNames = true)]
    public class ProjectDetailsColumns
    {
        [EditLink, Width(160)]


        public String DesignTypeId { get; set; }

        [Width(70)]
        public Decimal Width { get; set;
        }
        [Width(70)]
        public Decimal High { get; set; }

        [Width(70)]

        public Decimal Deep { get; set; }


        public String Observaciones { get; set; }

     

        public ProdStatus? Cutter { get; set; }
        public ProdStatus? Cnc { get; set; }
        public ProdStatus? Plating { get; set; }
        public ProdStatus? Detailed { get; set; }
        public ProdStatus? Armed { get; set; }
        public ProdStatus? Packed { get; set; }
        public ProdStatus? Installed { get; set; }
    }
}