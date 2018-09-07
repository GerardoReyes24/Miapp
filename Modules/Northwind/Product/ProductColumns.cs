
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
        public String ProductName { get; set; }
        [EditLink(ItemType = "Northwind.Supplier"), QuickFilter]
        public String SupplierCompanyName { get; set; }
      //  [EditLink(ItemType = "Northwind.Category"), Width(150), QuickFilter, QuickFilterOption("multiple", true)]
    /*    public String CategoryName { get; set; }
        [Width(130)] */
        

      public Decimal UnitPrice { get; set; }
        [Width(200), AlignRight]
        public Int16 UnitsInStock { get; set; }
       
    }
}