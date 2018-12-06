
namespace Miapp2.Northwind.Lookups
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Web;

    [LookupScript]
    public class ProductLookup : RowLookupScript<ProductRow>
    {
        public ProductLookup()
        {
            IdField = ProductRow.Fields.ProductID.PropertyName;
            TextField = ProductRow.Fields.ProductName.PropertyName;
        }
    }
}