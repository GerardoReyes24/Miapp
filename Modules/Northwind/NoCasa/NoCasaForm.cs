
namespace Miapp2.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Northwind.NoCasa")]
    [BasedOnRow(typeof(Entities.NoCasaRow), CheckNames = true)]
    public class NoCasaForm
    {
        public String NumeroCasa { get; set; }
    }
}