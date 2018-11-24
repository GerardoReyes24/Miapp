namespace Miapp2.Northwind.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[GrossSales]")]
    [DisplayName("Resumen de costos")]
    [ReadPermission("Northwind:General")]
    [ModifyPermission("Northwind:General")]
    public sealed class CustomerGrossSalesRow : Row, INameRow
    {
        [DisplayName("Customer Id"), Column("ProyectorID"), NotNull]
        public Int32? ProyectorId
        {
            get { return Fields.ProyectorId[this]; }
            set { Fields.ProyectorId[this] = value; }
        }

        [DisplayName("Proyecto "), Size(40), NotNull, QuickSearch]
        public String ProyectorName
        {
            get { return Fields.ProyectorName[this]; }
            set { Fields.ProyectorName[this] = value; }
        }

        [DisplayName("Product Id"), Column("NoCasaID"), NotNull]
        public Int32? NoCasaId
        {
            get { return Fields.NoCasaId[this]; }
            set { Fields.NoCasaId[this] = value; }
        }

        [DisplayName("Numero Casa"), Size(40), NotNull, QuickSearch]
        public String NumeroCasa
        {
            get { return Fields.NumeroCasa[this]; }
            set { Fields.NumeroCasa[this] = value; }
        }

        [DisplayName("TipoMueble Id"), Column("TipoMuebleID"), NotNull]
        public Int32? TipoMuebleId
        {
            get { return Fields.TipoMuebleId[this]; }
            set { Fields.TipoMuebleId[this] = value; }
        }


        [DisplayName("Mueble"), Size(40), NotNull, QuickSearch]
        public String MuebleName
        {
            get { return Fields.MuebleName[this]; }
            set { Fields.MuebleName[this] = value; }
        }


        [DisplayName("Registro Id"), Column("RegistroID"), NotNull]
        public Int32? RegistroId
        {
            get { return Fields.RegistroId[this]; }
            set { Fields.RegistroId[this] = value; }
        }

        [DisplayName("Cantidad"), Size(18), Scale(2), NotNull]
        public Decimal? Cantidad
        {
            get { return Fields.Cantidad[this]; }
            set { Fields.Cantidad[this] = value; }
        }

        [DisplayName("Material"), Column("ProductID"), Size(15), NotNull]
    
        public String ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Material")]
        public String ProductName
        {
            get { return Fields.ProductName[this]; }
            set { Fields.ProductName[this] = value; }
        }



        [DisplayName("Costo"), Size(19), Scale(2)]
        public Decimal? GrossAmount
        {
            get { return Fields.GrossAmount[this]; }
            set { Fields.GrossAmount[this] = value; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ProyectorName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomerGrossSalesRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProyectorId;
            public StringField ProyectorName;
            public Int32Field NoCasaId;
            public StringField NumeroCasa;
            public DecimalField GrossAmount;
            public Int32Field TipoMuebleId;
            public StringField MuebleName;
            public Int32Field RegistroId;
            public DecimalField Cantidad;
            public StringField ProductId;
            public StringField ProductName;
        }
    }
}