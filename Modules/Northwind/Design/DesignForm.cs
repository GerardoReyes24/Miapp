
namespace Miapp2.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Northwind.Design")]
    [BasedOnRow(typeof(Entities.DesignRow), CheckNames = true)]
    public class DesignForm
    {
        public DateTime Date { get; set; }
        public Int32 DesignTypeId { get; set; }
        public Decimal DesignTime { get; set; }
        public Boolean DesignInTime { get; set; }
        public Boolean Aproved { get; set; }
    }
}