using Serenity.Navigation;
using Administration = Miapp2.Administration.Pages;

[assembly: NavigationMenu(9000, "Administración", icon: "fa-desktop")]
[assembly: NavigationLink(9000, "Administración/Idiomas", typeof(Administration.LanguageController), icon: "fa-comments")]
[assembly: NavigationLink(9000, "Administración/Translations", typeof(Administration.TranslationController), icon: "fa-comment-o")]
[assembly: NavigationLink(9000, "Administración/Sergen", typeof(Administration.SergenController), icon: "fa-magic")]
[assembly: NavigationLink(9000, "Administración/Roles", typeof(Administration.RoleController), icon: "fa-lock")]
[assembly: NavigationLink(9000, "Administración/Usuarios", typeof(Administration.UserController), icon: "fa-users")]