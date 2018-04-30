﻿
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

        [Category("C EXPRESS")]
        public Int32 Perforation5 { get; set; }
        public Int32 Perforation8 { get; set; }
        public Int32 Perforation10 { get; set; }
        public Int32 Perforation12 { get; set; }
        public Int32 Perforation15 { get; set; }
        public Int32 Perforation20 { get; set; }
        public Int32 Perforation35 { get; set; }
        public Int32 RauterM { get; set; }

        [Category("FORMAT")]
        public Int32 FormatM { get; set; }

        [Category("ORDENES")]
        public Int32 TotalOrder { get; set; }
        public Int32 ClosedOrder { get; set; }
        public Int32 OrderInTime { get; set; }
        public Int32 Claims { get; set; }
    }
}