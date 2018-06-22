using Serenity.Navigation;
using MyPages = Miapp2.ImportFiles.Pages;



[assembly: NavigationMenu(9000, "Importar Archivos", icon: "fa-file-excel-o")]

[assembly: NavigationLink(9200, "Importar Archivos/Pieza", typeof(MyPages.PiezaController), icon: "fa-file-excel-o")]