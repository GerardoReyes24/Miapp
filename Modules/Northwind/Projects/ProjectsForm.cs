
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


        [Tab ("Diseños del proyecto")]
        [Category("Detalles por proyecto")]
        [ProjectDetailsEditor]
        public List<Entities.ProjectDetailsRow> DetailList { get; set; }


        [Tab("Estatus del diseño")]

        [Category("Estatus Diseño")]
        public Boolean? Blueprints { get; set; }
        public Boolean? PorposalFirst { get; set; }
        public Boolean? Measures { get; set; }
        [HalfWidth]
        public Boolean? Corrections { get; set; }

        public Boolean? PorposalFinal { get; set; }
    }
}