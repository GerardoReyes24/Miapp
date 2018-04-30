
namespace Miapp2.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Northwind.ProjectDetails")]
    [BasedOnRow(typeof(Entities.ProjectDetailsRow), CheckNames = true)]
    public class ProjectDetailsForm
    {
    
        public Int32 DesignTypeId { get; set; }
        public Decimal Width { get; set; }
        public Decimal High { get; set; }

        public Decimal Deep { get; set; }
        public String Observaciones { get; set; }

        [Category("Estatus Producción")]
        [ProductionStEditor]
        public List<Entities.ProductionStRow> ProductionStList { get; set; }

    }
}