using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Miapp2.Northwind
{
    public partial class ProductionStGridAttribute : CustomEditorAttribute
    {
        public const string Key = "Miapp2.Northwind.ProductionStGrid";

        public ProductionStGridAttribute()
            : base(Key)
        {
        }
    }
}
