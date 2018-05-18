
namespace Miapp2.ImportFiles.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("ImportFiles"), TableName("[dbo].[Prueba]")]
    [DisplayName("Prueba"), InstanceName("Prueba")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PruebaRow : Row, IIdRow, INameRow
    {
        [DisplayName("Type1"), Size(40)]
        public String Type1
        {
            get { return Fields.Type1[this]; }
            set { Fields.Type1[this] = value; }
        }

        [DisplayName("Type2")]
        public Int32? Type2
        {
            get { return Fields.Type2[this]; }
            set { Fields.Type2[this] = value; }
        }

        [DisplayName("Type3"), Size(18)]
        public Decimal? Type3
        {
            get { return Fields.Type3[this]; }
            set { Fields.Type3[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Type1; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Type1; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PruebaRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField Type1;
            public Int32Field Type2;
            public DecimalField Type3;
		}
    }
}
