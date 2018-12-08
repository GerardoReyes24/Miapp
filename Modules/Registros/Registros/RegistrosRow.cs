
namespace Miapp2.Registros.Entities
{
    using Miapp2.Northwind;
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
    [DisplayName("Registros"), InstanceName("Registros")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
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

        [DisplayName("Material"), Column("ProductID"), Size(15), NotNull, ForeignKey(typeof(ProductRow), "ProductID"), LeftJoin("jProduct"), ProductEditor]
      //  [LookupEditor(typeof(ProductRow), InplaceAdd = true)]
        public String ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Cantidad"), Size(18), Scale(2), NotNull]
        public Decimal? Cantidad
        {
            get { return Fields.Cantidad[this]; }
            set { Fields.Cantidad[this] = value; }
        }

        [DisplayName("Movimiento"), NotNull]
        public TipoMovimiento? Movimiento
        {
            get { return (TipoMovimiento)Fields.Movimiento[this]; }
            set { Fields.Movimiento[this] = (Int32?)value; }
        }

        [DisplayName("No Orden"), Size(40)]
        public String NoOrden
        {
            get { return Fields.NoOrden[this]; }
            set { Fields.NoOrden[this] = value; }
        }

        [DisplayName("Proyecto"), Column("ProyectorID"), ForeignKey("[dbo].[ProyectoR]", "ProyectorID"), LeftJoin("jProyector"), TextualField("ProyectorProyectorName")]
        [LookupEditor(typeof(ProyectoRRow), InplaceAdd = true)]
        public Int32? ProyectorId
        {
            get { return Fields.ProyectorId[this]; }
            set { Fields.ProyectorId[this] = value; }
        }

        [DisplayName("Tipo de Mueble"), Column("TipoMuebleID"), ForeignKey("[dbo].[TipoMueble]", "TipoMuebleID"), LeftJoin("jTipoMueble"), TextualField("TipoMuebleMuebleName")]
        [LookupEditor(typeof(TipoMuebleRow), InplaceAdd = true)]
        public Int32? TipoMuebleId
        {
            get { return Fields.TipoMuebleId[this]; }
            set { Fields.TipoMuebleId[this] = value; }
        }

        [DisplayName("No Casa"), Column("NoCasaID"),  ForeignKey("[dbo].[NoCasa]", "NoCasaID"), LeftJoin("jNoCasa"), TextualField("NoCasaNumeroCasa")]
        [LookupEditor(typeof(NoCasaRow), InplaceAdd = true)]
        public Int32? NoCasaId
        {
            get { return Fields.NoCasaId[this]; }
            set { Fields.NoCasaId[this] = value; }
        }

        [DisplayName("Ubicación"), Column("RUbicacionID"), ForeignKey("[dbo].[RUbicacion]", "RUbicacionID"), LeftJoin("jRUbicacion"), TextualField("Ubicacion")]
        [LookupEditor(typeof(RUbicacionRow), InplaceAdd = true)]

        public Int32? RUbicacionId
        {
            get { return Fields.RUbicacionId[this]; }
            set { Fields.RUbicacionId[this] = value; }
        }

        [DisplayName("Material"), Expression("jProduct.[ProductName]"),QuickSearch]
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
        public Decimal? ProductUnitsInStock
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

        [DisplayName("Proyecto"), Expression("jProyector.[ProyectorName]")]
        public String ProyectorProyectorName
        {
            get { return Fields.ProyectorProyectorName[this]; }
            set { Fields.ProyectorProyectorName[this] = value; }
        }

        [DisplayName("Proyector Description"), Expression("jProyector.[Description]")]
        public String ProyectorDescription
        {
            get { return Fields.ProyectorDescription[this]; }
            set { Fields.ProyectorDescription[this] = value; }
        }

        [DisplayName("Tipo de Mueble "), Expression("jTipoMueble.[MuebleName]")]
        public String TipoMuebleMuebleName
        {
            get { return Fields.TipoMuebleMuebleName[this]; }
            set { Fields.TipoMuebleMuebleName[this] = value; }
        }

        [DisplayName("Tipo Mueble Mueble Description"), Expression("jTipoMueble.[MuebleDescription]")]
        public String TipoMuebleMuebleDescription
        {
            get { return Fields.TipoMuebleMuebleDescription[this]; }
            set { Fields.TipoMuebleMuebleDescription[this] = value; }
        }

        [DisplayName("Ubicación "), Expression("jRUbicacion.[RUbicacionN]")]
        public String RUbicacionN
        {
            get { return Fields.RUbicacionN[this]; }
            set { Fields.RUbicacionN[this] = value; }
        }

        [DisplayName("Descripción Ubicación"), Expression("jRUbicacion.[RUbicacionDesc]")]
        public String RUbicacionDesc
            
     
        {
            get { return Fields.RUbicacionDesc[this]; }
            set { Fields.RUbicacionDesc[this] = value; }
        }

        [DisplayName("No Casa "), Expression("jNoCasa.[NumeroCasa]")]
        public String NoCasaNumeroCasa
        {
            get { return Fields.NoCasaNumeroCasa[this]; }
            set { Fields.NoCasaNumeroCasa[this] = value; }
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
            public DecimalField Cantidad;
            public Int32Field Movimiento;
            public StringField NoOrden;
            public Int32Field ProyectorId;
            public Int32Field TipoMuebleId;
            public Int32Field NoCasaId;
            public Int32Field RUbicacionId;

            public StringField ProductProductName;
            public Int32Field ProductSupplierId;
            public Int32Field ProductCategoryId;
            public DecimalField ProductUnitPrice;
            public DecimalField ProductUnitsInStock;
            public BooleanField ProductDiscontinued;
            public StringField ProductProductImage;
            public StringField ProductProduct2Id;

            public StringField ProyectorProyectorName;
            public StringField ProyectorDescription;
            public StringField RUbicacionN;
            public StringField RUbicacionDesc;

            public StringField TipoMuebleMuebleName;
            public StringField TipoMuebleMuebleDescription;

            public StringField NoCasaNumeroCasa;
		}
    }
}
