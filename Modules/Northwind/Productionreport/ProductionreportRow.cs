namespace Miapp2.Northwind.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[GrossSales]")]
    [DisplayName("Reportes Producción")]
    [ReadPermission("Northwind:General")]
    [ModifyPermission("Northwind:General")]
    public sealed class ProductionreportRow : Row
    {
    

        

        [DisplayName("Corte"), Size(19), Scale(2)]
        public Decimal? CutterM
        {
            get { return Fields.CutterM[this]; }
            set { Fields.CutterM[this] = value; }
        }

        [DisplayName("Perforación"), Size(19), Scale(2)]
        public Decimal? Perforation5
        {
            get { return Fields.Perforation5[this]; }
            set { Fields.Perforation5[this] = value; }
        }

       

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductionreportRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
    
            public DecimalField CutterM;
            public DecimalField Perforation5;
        }
    }
}