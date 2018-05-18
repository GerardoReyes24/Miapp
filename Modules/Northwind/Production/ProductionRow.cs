
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[Production]")]
    [DisplayName("Production"), InstanceName("Production")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProductionRow : Row, IIdRow
    {
        [DisplayName("Production Id"), Column("ProductionID"), Identity]
        public Int32? ProductionId
        {
            get { return Fields.ProductionId[this]; }
            set { Fields.ProductionId[this] = value; }
        }

        [DisplayName("Fecha"), NotNull]
        public DateTime? Date
        {
            get { return Fields.Date[this]; }
            set { Fields.Date[this] = value; }
        }

        [DisplayName("Sierra M"), Size(18)]
        public Decimal? CutterM
        {
            get { return Fields.CutterM[this]; }
            set { Fields.CutterM[this] = value; }
        }

        [DisplayName("5")]
        public Int32? Perforation5
        {
            get { return Fields.Perforation5[this]; }
            set { Fields.Perforation5[this] = value; }
        }

        [DisplayName("8")]
        public Int32? Perforation8
        {
            get { return Fields.Perforation8[this]; }
            set { Fields.Perforation8[this] = value; }
        }

        [DisplayName("10")]
        public Int32? Perforation10
        {
            get { return Fields.Perforation10[this]; }
            set { Fields.Perforation10[this] = value; }
        }

        [DisplayName("12")]
        public Int32? Perforation12
        {
            get { return Fields.Perforation12[this]; }
            set { Fields.Perforation12[this] = value; }
        }

        [DisplayName("15")]
        public Int32? Perforation15
        {
            get { return Fields.Perforation15[this]; }
            set { Fields.Perforation15[this] = value; }
        }

        [DisplayName("20")]
        public Int32? Perforation20
        {
            get { return Fields.Perforation20[this]; }
            set { Fields.Perforation20[this] = value; }
        }

        [DisplayName("35")]
        public Int32? Perforation35
        {
            get { return Fields.Perforation35[this]; }
            set { Fields.Perforation35[this] = value; }
        }

        [DisplayName("Rauter M")]
        public Int32? RauterM
        {
            get { return Fields.RauterM[this]; }
            set { Fields.RauterM[this] = value; }
        }

        [DisplayName("Format M")]
        public Int32? FormatM
        {
            get { return Fields.FormatM[this]; }
            set { Fields.FormatM[this] = value; }
        }

        [DisplayName("Format M2")]
        public Int32? FormatM2
        {
            get { return Fields.FormatM2[this]; }
            set { Fields.FormatM2[this] = value; }
        }

        [DisplayName("Ordenes Totales")]
        public Int32? TotalOrder
        {
            get { return Fields.TotalOrder[this]; }
            set { Fields.TotalOrder[this] = value; }
        }

        [DisplayName("Término")]
        public Int32? ClosedOrder
        {
            get { return Fields.ClosedOrder[this]; }
            set { Fields.ClosedOrder[this] = value; }
        }

        [DisplayName("Ordenes a Tiempo")]
        public Int32? OrderInTime
        {
            get { return Fields.OrderInTime[this]; }
            set { Fields.OrderInTime[this] = value; }
        }

        [DisplayName("Reclamos de Calidad")]
        public Int32? Claims
        {
            get { return Fields.Claims[this]; }
            set { Fields.Claims[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ProductionId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProductionId;
            public DateTimeField Date;
            public DecimalField CutterM;
            public Int32Field Perforation5;
            public Int32Field Perforation8;
            public Int32Field Perforation10;
            public Int32Field Perforation12;
            public Int32Field Perforation15;
            public Int32Field Perforation20;
            public Int32Field Perforation35;
            public Int32Field RauterM;
            public Int32Field FormatM;
            public Int32Field FormatM2;
            public Int32Field TotalOrder;
            public Int32Field ClosedOrder;
            public Int32Field OrderInTime;
            public Int32Field Claims;
		}
    }
}
