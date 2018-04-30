
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
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProjectId { get; set; }
        [EditLink]
        public String CustomerCompanyName { get; set; }
        public String ProjectName { get; set; }
        public String Description { get; set; }
        public DateTime RequiredDate { get; set; }
        public String PriorityPriorityDescription { get; set; }
        public Boolean Aproved { get; set; }
    }
}