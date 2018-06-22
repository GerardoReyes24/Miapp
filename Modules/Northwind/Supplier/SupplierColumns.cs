
namespace Miapp2.Northwind.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("Northwind.Supplier")]
    [BasedOnRow(typeof(Entities.SupplierRow), CheckNames = true)]
    public class SupplierColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 SupplierID { get; set; }
        [EditLink, Width(250)]
        public String CompanyName { get; set; }
        [Width(150)]
        public String ContactName { get; set; }
        [Width(150)]
        public String Address { get; set; }



    }
}