
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[metodos]")]
    [DisplayName("Metodos"), InstanceName("Metodos")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CotizaRow : Row, IIdRow, INameRow
    {
        [DisplayName("Metod Id"), Column("MetodID"), Identity]
        public Int32? MetodId
        {
            get { return Fields.MetodId[this]; }
            set { Fields.MetodId[this] = value; }
        }

        [DisplayName("Metod Name"), Size(45), NotNull, QuickSearch]
        public String MetodName
        {
            get { return Fields.MetodName[this]; }
            set { Fields.MetodName[this] = value; }
        }

        [DisplayName("Metod Price"), Size(15), Scale(2)]
        public Decimal? MetodPrice
        {
            get { return Fields.MetodPrice[this]; }
            set { Fields.MetodPrice[this] = value; }
        }


     

        IIdField IIdRow.IdField
        {
            get { return Fields.MetodId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.MetodName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CotizaRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MetodId;
            public StringField MetodName;
            public DecimalField MetodPrice;
		}
    }
}
