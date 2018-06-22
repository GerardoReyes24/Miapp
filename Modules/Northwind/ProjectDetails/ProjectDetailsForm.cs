
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

    [FormScript("Northwind.ProjectDetails")]
    [BasedOnRow(typeof(Entities.ProjectDetailsRow), CheckNames = true)]
    public class ProjectDetailsForm
    {

        [Tab("Diseños")]
        [Category("Detalles del diseño")]
    
        public String DesignTypeId { get; set; }
        public Decimal Width { get; set; }
        public Decimal High { get; set; }

        public Decimal Deep { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Observaciones { get; set; }

        [Tab("Estado de Producción")]
        [Category("Estatus Producción")]

        public ProdStatus Cutter { get; set; }
        public ProdStatus Cnc { get; set; }
        public ProdStatus Plating { get; set; }
        public ProdStatus Detailed { get; set; }
        public ProdStatus Armed { get; set; }
        public ProdStatus Packed { get; set; }
        public ProdStatus Installed { get; set; }


    }
}