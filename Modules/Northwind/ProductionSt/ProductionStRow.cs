
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
    [DisplayName("Estatus producción"), InstanceName("Production St")]
    [ReadPermission(PermissionKeys.Projects.View)]
    [ModifyPermission(PermissionKeys.Projects.Modify)]
    [DeletePermission(PermissionKeys.Projects.Delete)]
    public sealed class ProductionStRow : Row, IIdRow
    {


        [DisplayName("Detail Id"), Column("DetailID"), PrimaryKey]
        public Int32? DetailID
        {
            get { return Fields.DetailID[this]; }
            set { Fields.DetailID[this] = value; }
        }

        [DisplayName("Corte K700"), NotNull]
        public ProdStatus? Cutter
        {
            get { return (ProdStatus)Fields.Cutter[this]; }
            set { Fields.Cutter[this] = (Int32?)value; }
        }

        [DisplayName("Perforaciones Cnc"), NotNull]
        public ProdStatus? Cnc
        {
            get { return (ProdStatus)Fields.Cnc[this]; }
            set { Fields.Cnc[this] = (Int32?) value; }
        }

        [DisplayName("Enchapado Perfect-608"), NotNull]
        public ProdStatus? Plating
        {
            get { return (ProdStatus)Fields.Plating[this]; }
            set { Fields.Plating[this] = (Int32?)value; }
        }

        [DisplayName("Acabado"), NotNull]
        public ProdStatus? Detailed
        {
            get { return (ProdStatus)Fields.Detailed[this]; }
            set { Fields.Detailed[this] = (Int32?)value; }
        }

        [DisplayName("Armado"), NotNull]
        public ProdStatus? Armed
        {
            get { return (ProdStatus)Fields.Armed[this]; }
            set { Fields.Armed[this] = (Int32?)value; }
        }

        [DisplayName("Empacado"), NotNull]
        public ProdStatus? Packed
        {
            get { return (ProdStatus)Fields.Packed[this]; }
            set { Fields.Packed[this] = (Int32?)value; }
        }

        [DisplayName("Istalación"), NotNull]
        public ProdStatus? Installed
        {
            get { return (ProdStatus)Fields.Installed[this]; }
            set { Fields.Installed[this] = (Int32?)value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.DetailID; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductionStRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
           
            public Int32Field DetailID;
            public Int32Field Cutter;
            public Int32Field Cnc;
            public Int32Field Plating;
            public Int32Field Detailed;
            public Int32Field Armed;
            public Int32Field Packed;
            public Int32Field Installed;
		}
    }
}
