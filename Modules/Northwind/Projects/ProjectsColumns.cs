
namespace Miapp2.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.Projects")]
    [BasedOnRow(typeof(Entities.ProjectsRow), CheckNames = true)]
    public class ProjectsColumns
    {
        [EditLink]

        [DisplayName("Cliente"), Width(100)]
        public String CustomerCompanyName { get; set; }
        public String ProjectName { get; set; }

        [DisplayName("Descripción "), Width(220)]
        public String Description { get; set; }

        [DisplayName("Fecha"), Width(100)]
        public DateTime RequiredDate { get; set; }

        [DisplayName("Prioridad"), Width(100)]
        public String PriorityPriorityDescription { get; set; }

        [DisplayName("Aprovado"), Width(100), AlignCenter]
        public Boolean Aproved { get; set; }
    }
}