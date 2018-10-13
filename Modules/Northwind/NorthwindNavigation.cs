using Serenity.Navigation;
using MyPages = Miapp2.Northwind.Pages;
using Northwind = Miapp2.Northwind.Pages;

[assembly: NavigationMenu(7000, "Controles", icon: "fa-university")]
//[assembly: NavigationLink(7100, "Controles/Clientes", typeof(Northwind.CustomerController), icon: "fa-credit-card")]
/*[assembly: NavigationLink(7200, "Controles/Orders", typeof(Northwind.OrderController), icon: "fa-shopping-cart")] */
[assembly: NavigationLink(7300, "Controles/Materiales", typeof(Northwind.ProductController), icon: "fa-cube")]
/*[assembly: NavigationLink(7600, "Controles/Categories", typeof(Northwind.CategoryController), icon: "fa-folder-o")]
[assembly: NavigationLink(7700, "Controles/Priority", typeof(MyPages.PriorityController), icon: null)]
*/
//[assembly: NavigationLink(7800, "Controles/Proyectos", typeof(MyPages.ProjectsController), icon: null)]
[assembly: NavigationLink(7900, "Controles/Provedores", typeof(Northwind.SupplierController), icon: "fa-truck")]

[assembly: NavigationLink(8600, "Controles/Categorias", typeof(Northwind.CategoryController), icon: "fa-folder-o")]



[assembly: NavigationLink(9000, "Controles/Producción", typeof(MyPages.ProductionController), icon: "fa-archive")]
[assembly: NavigationLink(9100, "Controles/Diseño", typeof(Northwind.DesignController ), icon: "far fa-clone")]
/*

[assembly: NavigationLink(9100, "Controles/Reporte Producción", typeof(MyPages.ProductionreportController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Northwind/Misdatos", typeof(MyPages.MisdatosController), icon: null)]

[assembly: NavigationLink(int.MaxValue, "Northwind/Proyecto R", typeof(MyPages.ProyectoRController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Northwind/Tipo Mueble", typeof(MyPages.TipoMuebleController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Northwind/No Casa", typeof(MyPages.NoCasaController), icon: null)]
 */
