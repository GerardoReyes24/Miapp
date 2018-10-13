using Serenity.Extensibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Miapp2.Registros
{

    [NestedPermissionKeys]
    [DisplayName("Registros")]
    public class RegistrosPermissionKey
    {
        [DisplayName("Registros")]
        public class Registros
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Registros:Registros:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Registros:Registros:Modify";
            public const string View = "Registros:Registros:View";
        }

        [DisplayName("Muestreos")]
        public class Muestreos
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Registros:Muestreos:Delete";
            [Description("Create/Update"), ImplicitPermission(View)]
            public const string Modify = "Registros:Muestreos:Modify";
            public const string View = "Registros:Muestreos:View";
        }

        [Description("[General]")]
        public const string General = "Registros:General";
    }
}
