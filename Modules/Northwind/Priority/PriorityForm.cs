
namespace Miapp2.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Northwind.Priority")]
    [BasedOnRow(typeof(Entities.PriorityRow), CheckNames = true)]
    public class PriorityForm
    {
        public int PriorityId { get; set; }
        public String PriorityDescription { get; set; }
    }
}