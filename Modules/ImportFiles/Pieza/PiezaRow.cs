
namespace Miapp2.ImportFiles.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("ImportFiles"), TableName("[dbo].[Pza]")]
    [DisplayName("Pieza"), InstanceName("Pieza")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PiezaRow : Row, IIdRow, INameRow
    {
        [DisplayName("Pza Id"), Column("PzaID"), Identity]
        public Int32? PzaId
        {
            get { return Fields.PzaId[this]; }
            set { Fields.PzaId[this] = value; }
        }

        [DisplayName("Pieza"), Size(40), QuickSearch]
        public String Pieza
        {
            get { return Fields.Pieza[this]; }
            set { Fields.Pieza[this] = value; }
        }

        [DisplayName("Grosor Tablero"), Size(10), Scale(2)]
        public Decimal? GrosTab
        {
            get { return Fields.GrosTab[this]; }
            set { Fields.GrosTab[this] = value; }
        }

        [DisplayName("Tipo de Enchapado"), Size(40)]
        public String Enchapado
        {
            get { return Fields.Enchapado[this]; }
            set { Fields.Enchapado[this] = value; }
        }

        [DisplayName("Metros Enchapado"), Size(10), Scale(2)]
        public Decimal? MtsEnchapado
        {
            get { return Fields.MtsEnchapado[this]; }
            set { Fields.MtsEnchapado[this] = value; }
        }

        [DisplayName("Metros Corte"), Size(10), Scale(2)]
        public Decimal? MtsCorte
        {
            get { return Fields.MtsCorte[this]; }
            set { Fields.MtsCorte[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.PzaId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Pieza; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PiezaRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field PzaId;
            public StringField Pieza;
            public DecimalField GrosTab;
            public StringField Enchapado;
            public DecimalField MtsEnchapado;
            public DecimalField MtsCorte;
		}
    }
}
