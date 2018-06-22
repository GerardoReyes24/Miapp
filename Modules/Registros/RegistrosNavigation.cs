using Serenity.Navigation;
using MyPages = Miapp2.Registros.Pages;



[assembly: NavigationMenu(9000, "Registros", icon: "fa-archive")]
[assembly: NavigationLink(9100, "Registros/Registros", typeof(MyPages.RegistrosController), icon: "fa-archive")]