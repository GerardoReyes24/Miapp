
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.Production")]
    [BasedOnRow(typeof(Entities.ProductionRow), CheckNames = true)]
    public class ProductionColumns
    {
        
      

        [EditLink, QuickFilter(CssClass = "hidden-xs")]
        public DateTime Date { get; set; }
        public Decimal CutterM { get; set; }

        [Category ("Perforaciones")]

        [DisplayName("Perforación 5"), Width(120)]
        public Int32 Perforation5 { get; set; }
        [DisplayName("Perforación 8"), Width(120)]
        public Int32 Perforation8 { get; set; }
        [DisplayName("Perforación 10"), Width(120)]
        public Int32 Perforation10 { get; set; }
        [DisplayName("Perforación 12"), Width(120)]
        public Int32 Perforation12 { get; set; }
        [DisplayName("Perforación 15"), Width(120)]
        public Int32 Perforation15 { get; set; }
        [DisplayName("Perforación 20"), Width(120)]
        public Int32 Perforation20 { get; set; }
        [DisplayName("Perforación 35"), Width(120)]
        public Int32 Perforation35 { get; set; }
        public Int32 RauterM { get; set; }
        public Int32 FormatM { get; set; }
        public Int32 FormatM2 { get; set; }
        public Int32 TotalOrder { get; set; }
        public Int32 ClosedOrder { get; set; }
        public Int32 OrderInTime { get; set; }
        public Int32 Claims { get; set; }
    }
}