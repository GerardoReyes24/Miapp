namespace Miapp2.BasicSamples.Columns
{
    using Serenity.ComponentModel;
    using System;

    [ColumnsScript("Northwind.Productionreport")]
    [BasedOnRow(typeof(Northwind.Entities.ProductionreportRow), CheckNames = true)]
    public class ProductionreportColumns
    {
      

        [Width(150), AlignRight, SortOrder(2, descending: true), DisplayFormat("#,##0.00")]
        public Decimal CutterM { get; set; }

        [Width(150), AlignRight, SortOrder(2, descending: true), DisplayFormat("#,##0.00")]
        public Decimal Perforation5 { get; set; }

    }
}