
namespace Miapp2.Northwind.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [FormScript("Northwind.Product")]
    [BasedOnRow(typeof(Entities.ProductRow), CheckNames = true)]
    public class ProductForm
    {
        [Category("General")]
        public String ProductID { get; set; }
        public String Product2ID { get; set; }
        public String ProductName { get; set; }
        public String ProductImage { get; set; }
      //  public Boolean Discontinued { get; set; }
        public Int32 SupplierID { get; set; }
        public Int32 CategoryID { get; set; }
        public Decimal UnitPrice { get; set; }

        public Int16 UnitsInStock { get; set; }

        public String QuantityPerUnit { get; set; }



    }
}