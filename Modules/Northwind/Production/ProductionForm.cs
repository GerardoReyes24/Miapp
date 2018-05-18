
namespace Miapp2.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Northwind.Production")]
    [BasedOnRow(typeof(Entities.ProductionRow), CheckNames = true)]
    public class ProductionForm
    {

        [Tab("Reporte Producción")]
       
        public DateTime Date { get; set; }
        [Category("Sierra")]
        public Decimal CutterM { get; set; }

        [Tab ("C-EXPRESS")]
        [Category("Perforaciones C-EXPRESS")]
        
        [DisplayName("Perforaciones No 5")]
        public Int32 Perforation5 { get; set; }
        [DisplayName("Perforaciones No 8")]
        public Int32 Perforation8 { get; set; }
        [DisplayName("Perforaciones No 8")]
        public Int32 Perforation10 { get; set; }
        [DisplayName("Perforaciones No 12")]
        public Int32 Perforation12 { get; set; }
        [DisplayName("Perforaciones No 15")]
        public Int32 Perforation15 { get; set; }
        [DisplayName("Perforaciones No 20")]
        public Int32 Perforation20 { get; set; }
        [DisplayName("Perforaciones No 35")]
        public Int32 Perforation35 { get; set; }
        [DisplayName("Rauter Metros")]
        public Int32 RauterM { get; set; }
        [Tab("FORMAT")]

        [Category("FORMAT")]
        public Int32 FormatM { get; set; }
        public Int32 FormatM2 { get; set; }

        [Tab("ORDENES")]

        [Category("ORDENES")]
        public Int32 TotalOrder { get; set; }
        public Int32 ClosedOrder { get; set; }
        public Int32 OrderInTime { get; set; }
        public Int32 Claims { get; set; }
    }
}