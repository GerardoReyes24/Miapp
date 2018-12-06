
namespace Miapp2.Northwind.Columns
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("Northwind.Product")]
    [BasedOnRow(typeof(Entities.ProductRow), CheckNames = true)]
    public class ProductColumns
    {
      [EditLink, Width(250)]
        public String ProductID { get; set; }
      [EditLink, Width(250)]
        public String Product2ID { get; set; }
        [Width(150), QuickFilter, QuickFilterOption("multiple", true)]
        public String CategoryName { get; set; }

        [QuickFilter]
        public String SupplierCompanyName { get; set; }
    
        //  [Width(130)] 
        public String ProductName { get; set; }


        [Width(150)]
        public Decimal UnitPrice { get; set; }
        [Width(200)]
        public Int16 UnitsInStock { get; set; }

        public String QuantityPerUnit { get; set; }


    }
}