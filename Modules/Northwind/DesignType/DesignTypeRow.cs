
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[DesignType]")]
    [DisplayName("Design Type"), InstanceName("Design Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class DesignTypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Clave"), Column("DesignTypeID"), Identity]
        public Int32? DesignTypeId
        {
            get { return Fields.DesignTypeId[this]; }
            set { Fields.DesignTypeId[this] = value; }
        }

        [DisplayName("Tipo de diseño"), Size(50), NotNull, QuickSearch, LookupInclude]
        public String DesType
        {
            get { return Fields.DesType[this]; }
            set { Fields.DesType[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.DesignTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.DesType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DesignTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DesignTypeId;
            public StringField DesType;
		}
    }
}
