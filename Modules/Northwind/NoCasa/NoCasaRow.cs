
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[NoCasa]")]
    [DisplayName("No Casa"), InstanceName("No Casa")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class NoCasaRow : Row, IIdRow, INameRow
    {
        [DisplayName("No Casa Id"), Column("NoCasaID"), Identity]
        public Int32? NoCasaId
        {
            get { return Fields.NoCasaId[this]; }
            set { Fields.NoCasaId[this] = value; }
        }

        [DisplayName("Numero Casa"), Size(55), NotNull, QuickSearch]
        public String NumeroCasa
        {
            get { return Fields.NumeroCasa[this]; }
            set { Fields.NumeroCasa[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.NoCasaId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.NumeroCasa; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public NoCasaRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field NoCasaId;
            public StringField NumeroCasa;
		}
    }
}
