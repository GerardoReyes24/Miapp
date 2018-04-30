
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[Design]")]
    [DisplayName("Design"), InstanceName("Design")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class DesignRow : Row, IIdRow
    {
        [DisplayName("Design Id"), Column("DesignID"), Identity]
        public Int32? DesignId
        {
            get { return Fields.DesignId[this]; }
            set { Fields.DesignId[this] = value; }
        }

        [DisplayName("Fecha")]
        public DateTime? Date
        {
            get { return Fields.Date[this]; }
            set { Fields.Date[this] = value; }
        }

        [DisplayName("Tipo de diseño"), Column("DesignTypeID"), ForeignKey("[dbo].[DesignType]", "DesignTypeID"), LeftJoin("jDesignType"), TextualField("DesignTypeDesType")]
        [LookupEditor(typeof(DesignTypeRow), InplaceAdd = true)]
        public Int32? DesignTypeId
        {
            get { return Fields.DesignTypeId[this]; }
            set { Fields.DesignTypeId[this] = value; }
        }

        [DisplayName("Tiempo invertido"), Size(18)]
        public Decimal? DesignTime
        {
            get { return Fields.DesignTime[this]; }
            set { Fields.DesignTime[this] = value; }
        }

        [DisplayName("¿A tiempo?"), NotNull]
        public Boolean? DesignInTime
        {
            get { return Fields.DesignInTime[this]; }
            set { Fields.DesignInTime[this] = value; }
        }

        [DisplayName("Aprovado"), NotNull]
        public Boolean? Aproved
        {
            get { return Fields.Aproved[this]; }
            set { Fields.Aproved[this] = value; }
        }

        [DisplayName("Tipo de diseño"), Expression("jDesignType.[DesType]")]
        public String DesignTypeDesType
        {
            get { return Fields.DesignTypeDesType[this]; }
            set { Fields.DesignTypeDesType[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.DesignId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DesignRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DesignId;
            public DateTimeField Date;
            public Int32Field DesignTypeId;
            public DecimalField DesignTime;
            public BooleanField DesignInTime;
            public BooleanField Aproved;

            public StringField DesignTypeDesType;
		}
    }
}
