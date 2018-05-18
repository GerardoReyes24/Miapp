namespace Miapp2.BasicSamples
{
    using Serenity.Services;
    using System;

    public class ProductionreportListRequest : ListRequest
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}