
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[misdatos]")]
    [DisplayName("Misdatos"), InstanceName("Misdatos")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MisdatosRow : Row, IIdRow, INameRow
    {
        [DisplayName("Campo1"), Column("campo1"), Size(50), QuickSearch]
        public String Campo1
        {
            get { return Fields.Campo1[this]; }
            set { Fields.Campo1[this] = value; }
        }

        [DisplayName("Campo2"), Column("campo2")]
        public Int32? Campo2
        {
            get { return Fields.Campo2[this]; }
            set { Fields.Campo2[this] = value; }
        }

        [DisplayName("Campo3"), Column("campo3"), Size(12), Scale(2)]
        public Decimal? Campo3
        {
            get { return Fields.Campo3[this]; }
            set { Fields.Campo3[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Campo1; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Campo1; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MisdatosRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField Campo1;
            public Int32Field Campo2;
            public DecimalField Campo3;
		}
    }
}
