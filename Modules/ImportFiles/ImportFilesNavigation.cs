using Serenity.Navigation;
using MyPages = Miapp2.ImportFiles.Pages;



[assembly: NavigationMenu(9000, "Importar Archivos", icon: "fa-file-excel-o")]
[assembly: NavigationLink(9100, "Importar Archivos/Prueba", typeof(MyPages.PruebaController), icon: "fa-file-excel-o")]