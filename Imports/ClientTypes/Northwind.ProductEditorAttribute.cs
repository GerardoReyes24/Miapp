using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Miapp2.Northwind
{
    public partial class ProductEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "Miapp2.Northwind.ProductEditor";

        public ProductEditorAttribute()
            : base(Key)
        {
        }
    }
}
