using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Miapp2.Northwind
{
    public partial class ProductionStEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Miapp2.Northwind.ProductionStEditor";

        public ProductionStEditorAttribute()
            : base(Key)
        {
        }
    }
}
