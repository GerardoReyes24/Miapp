
namespace Miapp2.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Northwind.ProyectoR")]
    [BasedOnRow(typeof(Entities.ProyectoRRow), CheckNames = true)]
    public class ProyectoRForm
    {
        public String ProyectorName { get; set; }
        public String Description { get; set; }
    }
}