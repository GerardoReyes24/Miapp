namespace Miapp2.Northwind.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[GrossSales]")]
    [DisplayName("Customer Gross Sales")]
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
        public String NoCasaNumeroCasa
        {
            get { return Fields.NoCasaNumeroCasa[this]; }
            set { Fields.NoCasaNumeroCasa[this] = value; }
        }

        [DisplayName("Gross Amount"), Size(19), Scale(2)]
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
            public StringField NoCasaNumeroCasa;
            public DecimalField GrossAmount;
        }
    }
}