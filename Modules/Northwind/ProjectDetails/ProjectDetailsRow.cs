
namespace Miapp2.Northwind.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[Project Details]")]
    [DisplayName("Project Details"), InstanceName("Project Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProjectDetailsRow : Row, IIdRow
    {
        [DisplayName("Detail Id"), Column("DetailID"), Identity]
        public Int32? DetailId
        {
            get { return Fields.DetailId[this]; }
            set { Fields.DetailId[this] = value; }
        }

        [DisplayName("Proyecto"), Column("ProjectID"), PrimaryKey, ForeignKey(typeof(ProjectsRow)), LeftJoin("o"), Updatable(false)]
        public Int32? ProjectId
        {
            get { return Fields.ProjectId[this]; }
            set { Fields.ProjectId[this] = value; }
        }


        [DisplayName("Tipo de diseño"), Column("DesignTypeID"), ForeignKey("[dbo].[DesignType]", "DesignTypeID"), LeftJoin("jDesignType"), TextualField("DesignTypeDesType")]
        [LookupEditor(typeof(DesignTypeRow), InplaceAdd = true)]
        public Int32? DesignTypeId
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

        public Decimal? High
        {
            get { return Fields.High[this]; }
            set { Fields.High[this] = value; }
        }

        public Decimal? Deep
        {
            get { return Fields.Deep[this]; }
            set { Fields.Deep[this] = value; }
        }



        [DisplayName("Tipo de diseño"), Expression("jDesignType.[DesType]")]
        public String DesignType
        {
            get { return Fields.DesignType[this]; }
            set { Fields.DesignType[this] = value; }
        }

 

      

      

        [DisplayName("Observaciones"), Size(35)]
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

        [DisplayName("Project Started"), Expression("jProject.[Started]")]
        public Boolean? ProjectAproved
        {
            get { return Fields.ProjectAproved[this]; }
            set { Fields.ProjectAproved[this] = value; }
        }



  


        IIdField IIdRow.IdField
        {
            get { return Fields.DetailId; }
        }

     

        public static readonly RowFields Fields = new RowFields().Init();

        public ProjectDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DetailId;
            public Int32Field ProjectId;
            public Int32Field DesignTypeId;
            public DecimalField Width;
            public DecimalField Deep;
            public DecimalField High;


            public StringField Observaciones;

            public StringField DesignType;


            public StringField ProjectCustomerId;
            public StringField ProjectProjectName;
            public StringField ProjectDescription;
            public DateTimeField ProjectRequiredDate;
            public Int32Field ProjectPriorityId;
            public BooleanField ProjectAproved;

        
		}
    }
}
