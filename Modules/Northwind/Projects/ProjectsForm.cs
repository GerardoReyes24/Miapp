
namespace Miapp2.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Northwind.Projects")]
    [BasedOnRow(typeof(Entities.ProjectsRow), CheckNames = true)]
    public class ProjectsForm
    {

        [Tab("General")]
        [Category("Proyectos")]
        public String CustomerId { get; set; }
        public String ProjectName { get; set; }
        public String Description { get; set; }
        public DateTime RequiredDate { get; set; }
        public Int32 PriorityId { get; set; }
        public Boolean Aproved { get; set; }



        [Category("Detalles por proyecto")]
        [ProjectDetailsEditor]
        public List<Entities.ProjectDetailsRow> DetailList { get; set; }

    
    }
}