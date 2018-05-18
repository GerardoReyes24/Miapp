using Serenity.Extensibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Miapp2.Northwind.BasicSamples
{
    [NestedPermissionKeys]
    [DisplayName("Temas")]
    public class PermissionKeys
    {

       

        [Description("General")]
        public const string General = "BasicSamples:General";

    }
}



