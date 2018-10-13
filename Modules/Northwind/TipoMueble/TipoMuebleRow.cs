
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[TipoMueble]")]
    [DisplayName("Tipo Mueble"), InstanceName("Tipo Mueble")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class TipoMuebleRow : Row, IIdRow, INameRow
    {
        [DisplayName("Tipo Mueble Id"), Column("TipoMuebleID"), Identity]
        public Int32? TipoMuebleId
        {
            get { return Fields.TipoMuebleId[this]; }
            set { Fields.TipoMuebleId[this] = value; }
        }

        [DisplayName("Mueble Name"), Size(55), NotNull, QuickSearch]
        public String MuebleName
        {
            get { return Fields.MuebleName[this]; }
            set { Fields.MuebleName[this] = value; }
        }

        [DisplayName("Mueble Description"), Size(1073741823)]
        public String MuebleDescription
        {
            get { return Fields.MuebleDescription[this]; }
            set { Fields.MuebleDescription[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.TipoMuebleId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.MuebleName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TipoMuebleRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TipoMuebleId;
            public StringField MuebleName;
            public StringField MuebleDescription;
		}
    }
}
