
namespace Miapp2.Northwind.Entities
{
    using Miapp2.Registros.Entities;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[Project Details]")]
    [DisplayName("Detalles del proyecto"), InstanceName("Project Details")]
    [LeftJoin("ps", "ProductionSt", "ps.[DetailID] = t0.[DetailID]", RowType = typeof(ProductionStRow), TitlePrefix = "")]
    [UpdatableExtension("ps", typeof(ProductionStRow), CascadeDelete = true)]

    [ReadPermission(PermissionKeys.Projects.View)]
    [ModifyPermission(PermissionKeys.Projects.Modify)]
    [DeletePermission(PermissionKeys.Projects.Delete)]
    [LookupScript("Somes.Lookup", Permission = "?")]
    public sealed class ProjectDetailsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Detail Id"), Identity, PrimaryKey]
        public Int32? DetailID
        {
            get { return Fields.DetailID[this]; }
            set { Fields.DetailID[this] = value; }
        }

        [DisplayName("Proyecto"), PrimaryKey, ForeignKey(typeof(ProjectsRow)), LeftJoin("o"), Updatable(false)]
        public Int32? ProjectID
        {
            get { return Fields.ProjectID[this]; }
            set { Fields.ProjectID[this] = value; }
        }


        [DisplayName("Tipo de diseño"), QuickSearch, LookupInclude]
        [ReadPermission(" SomeSpecialPermission ")]

        public String DesignTypeId
        {
            get { return Fields.DesignTypeId[this]; }
            set { Fields.DesignTypeId[this] = value; }
        }

        [DisplayName("Ancho"), Size(8)]
        public Decimal? Width
        {
            get { return Fields.Width[this]; }
            set { Fields.Width[this] = value; }
        }

        [DisplayName("Alto"), Size(8)]
        public Decimal? High
        {
            get { return Fields.High[this]; }
            set { Fields.High[this] = value; }
        }

        [DisplayName("Profundidad"), Size(10)]
        public Decimal? Deep
        {
            get { return Fields.Deep[this]; }
            set { Fields.Deep[this] = value; }
        }

/*
        [Origin("des"), MinSelectLevel(SelectLevel.List)]
        public String DesType
        {
            get { return Fields.DesType[this]; }
            set { Fields.DesType[this] = value; }
        }


*/




        [DisplayName("Observaciones"), Size(75)]
        public String Observaciones
        {
            get { return Fields.Observaciones[this]; }
            set { Fields.Observaciones[this] = value; }
        }

        [DisplayName("Project Customer Id"), Expression("jProject.[CustomerID]")]
        public String ProjectCustomerId
        {
            get { return Fields.ProjectCustomerId[this]; }
            set { Fields.ProjectCustomerId[this] = value; }
        }

        [DisplayName("Project Project Name"), Expression("jProject.[ProjectName]")]
        public String ProjectProjectName
        {
            get { return Fields.ProjectProjectName[this]; }
            set { Fields.ProjectProjectName[this] = value; }
        }

        [DisplayName("Project Description"), Expression("jProject.[Description]")]
        public String ProjectDescription
        {
            get { return Fields.ProjectDescription[this]; }
            set { Fields.ProjectDescription[this] = value; }
        }

        [DisplayName("Project Required Date"), Expression("jProject.[RequiredDate]")]
        public DateTime? ProjectRequiredDate
        {
            get { return Fields.ProjectRequiredDate[this]; }
            set { Fields.ProjectRequiredDate[this] = value; }
        }

        [DisplayName("Project Priority Id"), Expression("jProject.[PriorityID]")]
        public Int32? ProjectPriorityId
        {
            get { return Fields.ProjectPriorityId[this]; }
            set { Fields.ProjectPriorityId[this] = value; }
        }

        [DisplayName("Proyecto Aprovado"), Expression("jProject.[Started]")]
        public Boolean? ProjectAproved
        {
            get { return Fields.ProjectAproved[this]; }
            set { Fields.ProjectAproved[this] = value; }
        }

        [Origin("ps"), DefaultValue(false), Width(100)]
        [MinSelectLevel(SelectLevel.List)]
        public ProdStatus? Cutter
        {
            get { return (ProdStatus)Fields.Cutter[this]; }
            set { Fields.Cutter[this] = (Int32?)value; }
        }

        [Origin("ps"), DefaultValue(false), Width(120)]
        [MinSelectLevel(SelectLevel.List)]
        public ProdStatus? Cnc
        {
            get { return (ProdStatus)Fields.Cnc[this]; }
            set { Fields.Cnc[this] = (Int32?)value; }
        }

        [Origin("ps"), DefaultValue(false), Width(160)]
        [MinSelectLevel(SelectLevel.List)]
        public ProdStatus? Plating
        {
            get { return (ProdStatus)Fields.Plating[this]; }
            set { Fields.Plating[this] = (Int32?)value; }
        }

        [Origin("ps"), DefaultValue(false), Width(80)]
        [MinSelectLevel(SelectLevel.List)]
        public ProdStatus? Detailed
        {
            get { return (ProdStatus)Fields.Detailed[this]; }
            set { Fields.Detailed[this] = (Int32?)value; }
        }

        [Origin("ps"), DefaultValue(false), Width(80)]
        [MinSelectLevel(SelectLevel.List)]
        public ProdStatus? Armed
        {
            get { return (ProdStatus)Fields.Armed[this]; }
            set { Fields.Armed[this] = (Int32?)value; }
        }

        [Origin("ps"), DefaultValue(false), Width(80)]
        [MinSelectLevel(SelectLevel.List)]
        public ProdStatus? Packed
        {
            get { return (ProdStatus)Fields.Packed[this]; }
            set { Fields.Packed[this] = (Int32?)value; }
        }

        [Origin("ps"), DefaultValue(true), Width(80)]
        [MinSelectLevel(SelectLevel.List)]
        public ProdStatus? Installed
        {
            get { return (ProdStatus)Fields.Installed[this]; }
            set { Fields.Installed[this] = (Int32?)value; }
        }




        IIdField IIdRow.IdField
        {
            get { return Fields.DetailID; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.DesignTypeId; }
        }



        public static readonly RowFields Fields = new RowFields().Init();

        public ProjectDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DetailID;
            public Int32Field ProjectID;
            public StringField DesignTypeId;
            public DecimalField Width;
            public DecimalField Deep;
            public DecimalField High;


            public StringField Observaciones;

          //  public StringField DesType;


            public StringField ProjectCustomerId;
            public StringField ProjectProjectName;
            public StringField ProjectDescription;
            public DateTimeField ProjectRequiredDate;
            public Int32Field ProjectPriorityId;
            public BooleanField ProjectAproved;
       
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
