
namespace Miapp2.Registros.Entities
{
    using Miapp2.Northwind.Entities;
    using Miapp2.Registros.Endpoints;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Registros"), TableName("[dbo].[Registros]")]
    [DisplayName("Registros de Entradas y Salidas"), InstanceName("Registros")]
    [ReadPermission(RegistrosPermissionKey.Registros.View)]
    [ModifyPermission(RegistrosPermissionKey.Registros.Modify)]
    [DeletePermission(RegistrosPermissionKey.Registros.Delete)]
    [LookupScript]
    public sealed class RegistrosRow : Row, IIdRow, INameRow
    {
        [DisplayName("Registro Id"), Column("RegistroID"), Identity]
        public Int32? RegistroId
        {
            get { return Fields.RegistroId[this]; }
            set { Fields.RegistroId[this] = value; }
        }

        [DisplayName("Fecha"), NotNull]
        public DateTime? Fecha
        {
            get { return Fields.Fecha[this]; }
            set { Fields.Fecha[this] = value; }
        }

        [DisplayName("Product"), Column("ProductID"), Size(15), NotNull, ForeignKey("[dbo].[Products]", "ProductID"), LeftJoin("jProduct"), QuickSearch, TextualField("ProductProductName")]
        [LookupEditor(typeof(ProductRow), InplaceAdd = true)]
        public String ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }


        [DisplayName("No de Orden")]
        public String NoOrder
        {
            get { return Fields.NoOrder[this]; }
            set { Fields.NoOrder[this] = value; }
        }

        [DisplayName("Cantidad"), Size(18), Scale(2), NotNull]
        public Decimal? Cantidad
        {
            get { return Fields.Cantidad[this]; }
            set { Fields.Cantidad[this] = value; }
        }

        [DisplayName("Movimiento")]     
        public TipoMovimiento? Movimiento
        {
            get { return (TipoMovimiento)Fields.Movimiento[this]; }
            set { Fields.Movimiento[this] = (Int32?)value; }
        }

        [DisplayName("Detail Id"), Column("DetailID"), Size(15), NotNull, ForeignKey("[dbo].[Project Details]", "DetailID"), LeftJoin("o"), QuickSearch, TextualField("Tipo de diseño")]
        [LookupEditor(typeof(ProjectDetailsRow), InplaceAdd = true)]
        public Int32? DetailID
        {
            get { return Fields.DetailID[this]; }
            set { Fields.DetailID[this] = value; }
        }

        [DisplayName("Tipo de diseño"), Expression("o.[DesignTypeID]"), QuickSearch]

        public String DesignTypeId
        {
            get { return Fields.DesignTypeId[this]; }
            set { Fields.DesignTypeId[this] = value; }
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

        [DisplayName("Project Id"), Column("ProjectID"), Size(15), NotNull, ForeignKey("[dbo].[Projects]", "ProjectID"), LeftJoin("pr"), QuickSearch, TextualField("Proyecto")]
        [LookupEditor(typeof(ProjectsRow), InplaceAdd = true)]
        public Int32? ProjectID
        {
            get { return Fields.ProjectID[this]; }
            set { Fields.ProjectID[this] = value; }
        }

   

        [DisplayName("Proyecto"), Size(35), Expression("pr.[ProjectName]"), QuickSearch]
        public String ProjectName
        {
            get { return Fields.ProjectName[this]; }
            set { Fields.ProjectName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.RegistroId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ProductId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RegistrosRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RegistroId;
            public DateTimeField Fecha;
            public StringField ProductId;
            public StringField NoOrder;
            public DecimalField Cantidad;
            public Int32Field Movimiento;
            public Int32Field DetailID;
            public StringField DesignTypeId;
            public StringField ProductProductName;
            public Int32Field ProductSupplierId;
            public Int32Field ProductCategoryId;
            public DecimalField ProductUnitPrice;
            public Int16Field ProductUnitsInStock;
            public BooleanField ProductDiscontinued;
            public StringField ProductProductImage;


            public Int32Field ProjectID;
      
            public StringField ProjectName;
        }
    }
}
