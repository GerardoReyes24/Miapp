
namespace Miapp2.Northwind.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Northwind.Supplier")]
    [BasedOnRow(typeof(Entities.SupplierRow), CheckNames = true)]
    public class SupplierForm
    {
        public String CompanyName { get; set; }
        public String ContactName { get; set; }
        public String Address { get; set; }


    }
}