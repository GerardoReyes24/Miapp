
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[ProductionSt]")]
    [DisplayName("Production St"), InstanceName("Production St")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProductionStRow : Row, IIdRow
    {
        [DisplayName("Production St Id"), Column("ProductionStID"), Identity]
        public Int32? ProductionStId
        {
            get { return Fields.ProductionStId[this]; }
            set { Fields.ProductionStId[this] = value; }
        }

        [DisplayName("Detail Id"), Column("DetailID"), NotNull]
        public Int32? DetailId
        {
            get { return Fields.DetailId[this]; }
            set { Fields.DetailId[this] = value; }
        }

        [DisplayName("Cutter")]
        public ProdStatus? Cutter
        {
            get { return (ProdStatus)Fields.Cutter[this]; }
            set { Fields.Cutter[this] = (Int32?)value; }
        }

        [DisplayName("Cnc")]
        public ProdStatus? Cnc
        {
            get { return (ProdStatus)Fields.Cnc[this]; }
            set { Fields.Cnc[this] = (Int32?) value; }
        }

        [DisplayName("Plating")]
        public ProdStatus? Plating
        {
            get { return (ProdStatus)Fields.Plating[this]; }
            set { Fields.Plating[this] = (Int32?)value; }
        }

        [DisplayName("Armed")]
        public ProdStatus? Armed
        {
            get { return (ProdStatus)Fields.Armed[this]; }
            set { Fields.Armed[this] = (Int32?)value; }
        }

        [DisplayName("Packed")]
        public ProdStatus? Packed
        {
            get { return (ProdStatus)Fields.Packed[this]; }
            set { Fields.Packed[this] = (Int32?)value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ProductionStId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductionStRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProductionStId;
            public Int32Field DetailId;
            public Int32Field Cutter;
            public Int32Field Cnc;
            public Int32Field Plating;
            public Int32Field Armed;
            public Int32Field Packed;
		}
    }
}
