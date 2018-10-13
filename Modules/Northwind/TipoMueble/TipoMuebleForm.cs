
namespace Miapp2.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Northwind.TipoMueble")]
    [BasedOnRow(typeof(Entities.TipoMuebleRow), CheckNames = true)]
    public class TipoMuebleForm
    {
        public String MuebleName { get; set; }
        public String MuebleDescription { get; set; }
    }
}