using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miapp2.Northwind
{
    public class ProjectsListRequest : ListRequest
    {
        public int? ProjectID { get; set; }
    }
}
