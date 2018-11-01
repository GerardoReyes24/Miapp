
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[RUbicacion]")]
    [DisplayName("R Ubicacion"), InstanceName("R Ubicacion")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class RUbicacionRow : Row, IIdRow, INameRow
    {
        [DisplayName("R Ubicacion Id"), Column("RUbicacionID"), Identity]
        public Int32? RUbicacionId
        {
            get { return Fields.RUbicacionId[this]; }
            set { Fields.RUbicacionId[this] = value; }
        }

        [DisplayName("Ubicación en Casa"), Size(55), NotNull, QuickSearch]
        public String RUbicacionN
        {
            get { return Fields.RUbicacionN[this]; }
            set { Fields.RUbicacionN[this] = value; }
        }

        [DisplayName("Descripción Ubicación"), Size(1073741823)]
        public String RUbicacionDesc
        {
            get { return Fields.RUbicacionDesc[this]; }
            set { Fields.RUbicacionDesc[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.RUbicacionId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.RUbicacionN; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RUbicacionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RUbicacionId;
            public StringField RUbicacionN;
            public StringField RUbicacionDesc;
		}
    }
}
