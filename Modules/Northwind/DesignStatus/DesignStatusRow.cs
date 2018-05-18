
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[DesignStatus]")]
    [DisplayName("Design Status"), InstanceName("Design Status")]
    [ReadPermission(PermissionKeys.Projects.View)]
    [ModifyPermission(PermissionKeys.Projects.Modify)]
    [DeletePermission(PermissionKeys.Projects.Delete)]
    public sealed class DesignStatusRow : Row, IIdRow
    {
        [DisplayName("Design Status Id"), Column("ProjectID"), PrimaryKey]
        public Int32? ProjectID
        {
            get { return Fields.ProjectID[this]; }
            set { Fields.ProjectID[this] = value; }
        }

        [DisplayName("Planos"), NotNull]
        public Boolean? Blueprints
        {
            get { return Fields.Blueprints[this]; }
            set { Fields.Blueprints[this] = value; }
        }

        [DisplayName("Primera propuesta"), NotNull]
        public Boolean? PorposalFirst
        {
            get { return Fields.PorposalFirst[this]; }
            set { Fields.PorposalFirst[this] = value; }
        }

        [DisplayName("Medidas"), NotNull]
        public Boolean? Measures
        {
            get { return Fields.Measures[this]; }
            set { Fields.Measures[this] = value; }
        }

        [DisplayName("Correcciones"), NotNull]
        public Boolean? Corrections
        {
            get { return Fields.Corrections[this]; }
            set { Fields.Corrections[this] = value; }
        }

        [DisplayName("Propuesta final"), NotNull]
        public Boolean? PorposalFinal
        {
            get { return Fields.PorposalFinal[this]; }
            set { Fields.PorposalFinal[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ProjectID; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DesignStatusRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProjectID;
            public BooleanField Blueprints;
            public BooleanField PorposalFirst;
            public BooleanField Measures;
            public BooleanField Corrections;
            public BooleanField PorposalFinal;
		}
    }
}
