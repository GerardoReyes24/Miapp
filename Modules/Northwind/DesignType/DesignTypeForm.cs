
namespace Miapp2.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Northwind.DesignType")]
    [BasedOnRow(typeof(Entities.DesignTypeRow), CheckNames = true)]
    public class DesignTypeForm
    {
        public String DesType { get; set; }
    }
}