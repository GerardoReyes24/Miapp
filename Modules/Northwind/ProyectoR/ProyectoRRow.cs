
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[ProyectoR]")]
    [DisplayName("Proyecto R"), InstanceName("Proyecto R")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class ProyectoRRow : Row, IIdRow, INameRow
    {
        [DisplayName("Proyector Id"), Column("ProyectorID"), Identity]
        public Int32? ProyectorId
        {
            get { return Fields.ProyectorId[this]; }
            set { Fields.ProyectorId[this] = value; }
        }

        [DisplayName("Proyector Name"), Size(55), NotNull, QuickSearch]
        public String ProyectorName
        {
            get { return Fields.ProyectorName[this]; }
            set { Fields.ProyectorName[this] = value; }
        }

        [DisplayName("Description"), Size(300)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ProyectorId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ProyectorName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProyectoRRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProyectorId;
            public StringField ProyectorName;
            public StringField Description;
		}
    }
}
