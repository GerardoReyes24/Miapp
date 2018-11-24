namespace Miapp2.BasicSamples.Columns
{
    using Serenity.ComponentModel;
    using System;

    [ColumnsScript("BasicSamples.CustomerGrossSales")]
    [BasedOnRow(typeof(Northwind.Entities.CustomerGrossSalesRow), CheckNames = true)]
    public class CustomerGrossSalesColumns
    {
        [Width(150), SortOrder(1)]
        public String ProyectorName { get; set; }

        [Width(250)]
        public String NumeroCasa { get; set; }

        [Width(250)]
        public String MuebleName { get; set; }

        [Width(150), AlignRight, SortOrder(2, descending: true), DisplayFormat("#,##0.00")]
        public Decimal GrossAmount { get; set; }
    }
}