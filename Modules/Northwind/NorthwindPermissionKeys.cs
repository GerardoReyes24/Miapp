﻿
using Serenity.Extensibility;
using System.ComponentModel;

namespace Miapp2.Northwind
{
    [NestedPermissionKeys]
    [DisplayName("Northwind")]
    public class PermissionKeys

    {


        [DisplayName("Clientes")]
        public class Customer
        {
          
            public const string Delete = "Northwind:Customer:Delete";
            [Description("Create/Update"), ImplicitPermission(General)]
            public const string Modify = "Northwind:Customer:Modify";
            public const string View = "Northwind:Customer:View";
        }

        [DisplayName ("Proyectos")]
        public class Projects
        {
       
            public const string Delete = "Northwind:Projects:Delete";
            [Description("Create/Update"), ImplicitPermission(General)]
            public const string Modify = "Northwind:Projects:Modify";
            public const string View = "Northwind:Projects:View";
        }

        [DisplayName("Materiales")]
        public class Materiales
        {
          
            public const string Delete = "Northwind:Product:Delete";
            [Description("Create/Update")]
            public const string Modify = "Northwind:Product:Modify";
            public const string View = "Northwind:Product:View";
        }

        [Description("[General]")]
        public const string General = "Northwind:General";
    }
}
