
namespace Miapp2.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Miapp2.Northwind.Entities;

    [FormScript("Northwind.ProductionSt")]
    [BasedOnRow(typeof(Entities.ProductionStRow), CheckNames = true)]
    public class ProductionStForm
    {
        public Int32 DetailId { get; set; }
        public ProdStatus Cutter { get; set; }
        public ProdStatus Cnc { get; set; }
        public ProdStatus Plating { get; set; }
        public ProdStatus Armed { get; set; }
        public ProdStatus Packed { get; set; }
    }
}