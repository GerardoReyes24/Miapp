using Serenity.Navigation;

[assembly: NavigationMenu(8000, "Temas", icon: "fa-diamond")]

[assembly: NavigationLink(8100, "Temas/Dashboard v2", url: "~/AdminLTE/DashboardV2", permission: "", icon: "fa-tachometer")]
[assembly: NavigationLink(8200, "Temas/Widgets", url: "~/AdminLTE/Widgets", permission: "", icon: "fa-th")]

[assembly: NavigationMenu(8300, "Temas/Charts", icon: "fa-pie-chart")]
[assembly: NavigationLink(8310, "Temas/Charts/ChartJS", url: "~/AdminLTE/Charts/ChartJS", permission: "")]
[assembly: NavigationLink(8320, "Temas/Charts/Morris", url: "~/AdminLTE/Charts/Morris", permission: "")]
[assembly: NavigationLink(8330, "Temas/Charts/Flot", url: "~/AdminLTE/Charts/Flot", permission: "")]

[assembly: NavigationMenu(8400, "Temas/UI Elements", icon: "fa-laptop")]
[assembly: NavigationLink(8410, "Temas/UI Elements/General", url: "~/AdminLTE/UIElements/General", permission: "")]
[assembly: NavigationLink(8420, "Temas/UI Elements/Icons", url: "~/AdminLTE/UIElements/Icons", permission: "")]
[assembly: NavigationLink(8430, "Temas/UI Elements/Buttons", url: "~/AdminLTE/UIElements/Buttons", permission: "")]
[assembly: NavigationLink(8440, "Temas/UI Elements/Sliders", url: "~/AdminLTE/UIElements/Sliders", permission: "")]
[assembly: NavigationLink(8450, "Temas/UI Elements/Timeline", url: "~/AdminLTE/UIElements/Timeline", permission: "")]
[assembly: NavigationLink(8460, "Temas/UI Elements/Modals", url: "~/AdminLTE/UIElements/Modals", permission: "")]

[assembly: NavigationMenu(8500, "Temas/Forms", icon: "fa-edit")]
[assembly: NavigationLink(8510, "Temas/Forms/General Elements", url: "~/AdminLTE/Forms/GeneralElements", permission: "")]
[assembly: NavigationLink(8520, "Temas/Forms/Advanced Elements", url: "~/AdminLTE/Forms/AdvancedElements", permission: "")]
[assembly: NavigationLink(8530, "Temas/Forms/Text Editors", url: "~/AdminLTE/Forms/TextEditors", permission: "")]

[assembly: NavigationMenu(8600, "Temas/Tables", icon: "fa-table")]
[assembly: NavigationLink(8610, "Temas/Tables/Simple Tables", url: "~/AdminLTE/Tables/SimpleTables", permission: "")]

[assembly: NavigationLink(8700, "Temas/Calendar", url: "~/AdminLTE/Calendar", permission: "", icon: "fa-calendar")]

[assembly: NavigationMenu(8800, "Temas/Mailbox", icon: "fa-envelope")]
[assembly: NavigationLink(8810, "Temas/Mailbox/Inbox", url: "~/AdminLTE/Mailbox/Inbox", permission: "")]
[assembly: NavigationLink(8820, "Temas/Mailbox/Compose", url: "~/AdminLTE/Mailbox/Compose", permission: "")]
[assembly: NavigationLink(8820, "Temas/Mailbox/Read", url: "~/AdminLTE/Mailbox/Read", permission: "")]

[assembly: NavigationMenu(8800, "Temass/Examples", icon: "fa-folder")]
[assembly: NavigationLink(8810, "Temas/Examples/Invoice", url: "~/AdminLTE/Examples/Invoice", permission: "")]
[assembly: NavigationLink(8820, "Temas/Examples/Profile", url: "~/AdminLTE/Examples/Profile", permission: "")]
[assembly: NavigationLink(8820, "Temas/Examples/Login", url: "~/AdminLTE/Examples/Login", permission: "")]
[assembly: NavigationLink(8820, "Temas/Examples/Register", url: "~/AdminLTE/Examples/Register", permission: "")]
[assembly: NavigationLink(8820, "Temas/Examples/Lockscreen", url: "~/AdminLTE/Examples/Lockscreen", permission: "")]
[assembly: NavigationLink(8820, "Temas/Examples/Error 404", url: "~/AdminLTE/Examples/Error404", permission: "")]
[assembly: NavigationLink(8820, "Temas/Examples/Error 500", url: "~/AdminLTE/Examples/Error500", permission: "")]
[assembly: NavigationLink(8820, "Temas/Examples/Blank Page", url: "~/AdminLTE/Examples/BlankPage", permission: "")]
[assembly: NavigationLink(8820, "Temas/Examples/Pace Page", url: "~/AdminLTE/Examples/PacePage", permission: "")]