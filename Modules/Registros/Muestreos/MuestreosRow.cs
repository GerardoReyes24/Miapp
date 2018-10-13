
namespace Miapp2.Registros.Entities
{
    using Miapp2.Northwind.Entities;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Registros"), TableName("[dbo].[Muestreos]")]
    [DisplayName("Muestreos"), InstanceName("Muestreos")]
    [ReadPermission(RegistrosPermissionKey.Muestreos.View)]
    [ModifyPermission(RegistrosPermissionKey.Muestreos.Modify)]
    [DeletePermission(RegistrosPermissionKey.Muestreos.Delete)]
    [LookupScript]
    public sealed class MuestreosRow : Row, IIdRow, INameRow
    {
        [DisplayName("Muestreos Id"), Column("MuestreosID"), Identity]
        public Int32? MuestreosId
        {
            get { return Fields.MuestreosId[this]; }
            set { Fields.MuestreosId[this] = value; }
        }

        [DisplayName("Fecha"), NotNull]
        public DateTime? Fecha
        {
            get { return Fields.Fecha[this]; }
            set { Fields.Fecha[this] = value; }
        }

        [DisplayName("Product"), Column("ProductID"), Size(15), NotNull, ForeignKey("[dbo].[Products]", "ProductID"), LeftJoin("jProduct"), QuickSearch, TextualField("ProductProductName")]
        [LookupEditor(typeof(ProductRow), InplaceAdd = true)]
        [ReadPermission(" SomeSpecialPermission ")]
        public String ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Cantidad A Muestrear"), Column("Cantidad_a_muestrear"), Size(18), Scale(2), NotNull]
        public Decimal? CantidadAMuestrear
        {
            get { return Fields.CantidadAMuestrear[this]; }
            set { Fields.CantidadAMuestrear[this] = value; }
        }

        [DisplayName("Cantidad Contada"), Column("Cantidad_contada"), Size(18), Scale(2), NotNull]
        public Decimal? CantidadContada
        {
            get { return Fields.CantidadContada[this]; }
            set { Fields.CantidadContada[this] = value; }
        }

        [DisplayName ("Desviaciòn economica"), Column("DesviacionEconomica")]
        public Decimal? DesviacionEconomica
        {

            get { return Fields.DesviacionEconomica[this]; }
            set { Fields.DesviacionEconomica[this] = value; }

        }

        [DisplayName("Product Product Name"), Expression("jProduct.[ProductName]")]
        public String ProductProductName
        {
            get { return Fields.ProductProductName[this]; }
            set { Fields.ProductProductName[this] = value; }
        }

        [DisplayName("Product Supplier Id"), Expression("jProduct.[SupplierID]")]
        public Int32? ProductSupplierId
        {
            get { return Fields.ProductSupplierId[this]; }
            set { Fields.ProductSupplierId[this] = value; }
        }

        [DisplayName("Product Category Id"), Expression("jProduct.[CategoryID]")]
        public Int32? ProductCategoryId
        {
            get { return Fields.ProductCategoryId[this]; }
            set { Fields.ProductCategoryId[this] = value; }
        }

        [DisplayName("Product Unit Price"), Expression("jProduct.[UnitPrice]")]
        public Decimal? ProductUnitPrice
        {
            get { return Fields.ProductUnitPrice[this]; }
            set { Fields.ProductUnitPrice[this] = value; }
        }

        [DisplayName("Product Units In Stock"), Expression("jProduct.[UnitsInStock]")]
        public Int16? ProductUnitsInStock
        {
            get { return Fields.ProductUnitsInStock[this]; }
            set { Fields.ProductUnitsInStock[this] = value; }
        }

        [DisplayName("Product Discontinued"), Expression("jProduct.[Discontinued]")]
        public Boolean? ProductDiscontinued
        {
            get { return Fields.ProductDiscontinued[this]; }
            set { Fields.ProductDiscontinued[this] = value; }
        }

        [DisplayName("Product Product Image"), Expression("jProduct.[ProductImage]")]
        public String ProductProductImage
        {
            get { return Fields.ProductProductImage[this]; }
            set { Fields.ProductProductImage[this] = value; }
        }

        [DisplayName("Product Product2 Id"), Expression("jProduct.[Product2ID]")]
        public String ProductProduct2Id
        {
            get { return Fields.ProductProduct2Id[this]; }
            set { Fields.ProductProduct2Id[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.MuestreosId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ProductId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MuestreosRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MuestreosId;
            public DateTimeField Fecha;
            public StringField ProductId;
            public DecimalField CantidadAMuestrear;
            public DecimalField CantidadContada;
            public DecimalField DesviacionEconomica;

            public StringField ProductProductName;
            public Int32Field ProductSupplierId;
            public Int32Field ProductCategoryId;
            public DecimalField ProductUnitPrice;
            public Int16Field ProductUnitsInStock;
            public BooleanField ProductDiscontinued;
            public StringField ProductProductImage;
            public StringField ProductProduct2Id;
		}
    }
}
