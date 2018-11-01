
namespace Miapp2.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Northwind.RUbicacion")]
    [BasedOnRow(typeof(Entities.RUbicacionRow), CheckNames = true)]
    public class RUbicacionForm
    {
        public String RUbicacionN { get; set; }
        public String RUbicacionDesc { get; set; }
    }
}