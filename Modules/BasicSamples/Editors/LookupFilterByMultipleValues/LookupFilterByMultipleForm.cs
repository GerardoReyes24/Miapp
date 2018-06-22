
namespace Miapp2.BasicSamples.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [FormScript("BasicSamples.LookupFilterByMultiple")]
    [BasedOnRow(typeof(Northwind.Entities.ProductRow), CheckNames = true)]
    public class LookupFilterByMultipleForm
    {
        [Category("General")]
        public String ProductName { get; set; }
        public String ProductImage { get; set; }
        public Boolean Discontinued { get; set; }
        public Int32 SupplierID { get; set; }
        [ProduceSeafoodCategoryEditor]
        public Int32 CategoryID { get; set; }
        [Category("Pricing")]
     
        public Decimal UnitPrice { get; set; }
        [Category("Status")]
        public Int16 UnitsInStock { get; set; }
     
    }
}