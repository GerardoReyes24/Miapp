
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[Priority]")]
    [DisplayName("Priority"), InstanceName("Priority")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class PriorityRow : Row, IIdRow, INameRow
    {
        [DisplayName("Priority Id"), Column("PriorityID"), PrimaryKey]
        public Int32? PriorityId
        {
            get { return Fields.PriorityId[this]; }
            set { Fields.PriorityId[this] = value; }
        }

        [DisplayName("Priority Description"), Size(50), NotNull, QuickSearch]
        public String PriorityDescription
        {
            get { return Fields.PriorityDescription[this]; }
            set { Fields.PriorityDescription[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.PriorityId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PriorityDescription; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PriorityRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field PriorityId;
            public StringField PriorityDescription;
		}
    }
}
