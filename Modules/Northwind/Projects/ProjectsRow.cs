
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

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("[dbo].[Projects]")]
    [DisplayName("Proyectos"), InstanceName("Projects")]
    [ReadPermission(PermissionKeys.Projects.View)]
    [ModifyPermission(PermissionKeys.Projects.Modify)]
    [DeletePermission(PermissionKeys.Projects.Delete)]
    [LeftJoin("ds", "DesignStatus", "ds.[ProjectID] = t0.[ProjectID]", RowType = typeof(DesignStatusRow), TitlePrefix = "")]
    [UpdatableExtension("ds", typeof(DesignStatusRow), CascadeDelete = true)]
  
   
    public sealed class ProjectsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Project Id"), Column("ProjectID"), Identity]
        public Int32? ProjectID
        {
            get { return Fields.ProjectID[this]; }
            set { Fields.ProjectID[this] = value; }
        }

        [DisplayName("Cliente"), Column("CustomerID"), Size(5), ForeignKey("[dbo].[Customers]", "CustomerID"), LeftJoin("jCustomer"), QuickSearch, TextualField("CustomerCompanyName")]
        [LookupEditor(typeof(CustomerRow), InplaceAdd = true)]
        public String CustomerId
        {
            get { return Fields.CustomerId[this]; }
            set { Fields.CustomerId[this] = value; }
        }

        [DisplayName("Proyecto"), Size(35)]
        public String ProjectName
        {
            get { return Fields.ProjectName[this]; }
            set { Fields.ProjectName[this] = value; }
        }

        [DisplayName("Descripción"), Size(100)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Fecha entrega")]
        public DateTime? RequiredDate
        {
            get { return Fields.RequiredDate[this]; }
            set { Fields.RequiredDate[this] = value; }
        }

        [DisplayName("Prioridad"), Column("PriorityID"), ForeignKey("[dbo].[Priority]", "PriorityID"), LeftJoin("jPriority"), TextualField("PriorityPriorityDescription")]
        [LookupEditor(typeof(PriorityRow), InplaceAdd = true)]
        public Int32? PriorityId
        {
            get { return Fields.PriorityId[this]; }
            set { Fields.PriorityId[this] = value; }
        }

        [DisplayName("Aprovado"), NotNull]
        public Boolean? Aproved
        {
            get { return Fields.Aproved[this]; }
            set { Fields.Aproved[this] = value; }
        }

        [DisplayName("Nombre del cliente"), Expression("jCustomer.[CompanyName]")]
        public String CustomerCompanyName
        {
            get { return Fields.CustomerCompanyName[this]; }
            set { Fields.CustomerCompanyName[this] = value; }
        }

        [DisplayName("Customer Contact Name"), Expression("jCustomer.[ContactName]")]
        public String CustomerContactName
        {
            get { return Fields.CustomerContactName[this]; }
            set { Fields.CustomerContactName[this] = value; }
        }

        [DisplayName("Customer Contact Title"), Expression("jCustomer.[ContactTitle]")]
        public String CustomerContactTitle
        {
            get { return Fields.CustomerContactTitle[this]; }
            set { Fields.CustomerContactTitle[this] = value; }
        }

        [DisplayName("Customer Address"), Expression("jCustomer.[Address]")]
        public String CustomerAddress
        {
            get { return Fields.CustomerAddress[this]; }
            set { Fields.CustomerAddress[this] = value; }
        }

        [DisplayName("Customer City"), Expression("jCustomer.[City]")]
        public String CustomerCity
        {
            get { return Fields.CustomerCity[this]; }
            set { Fields.CustomerCity[this] = value; }
        }

        [DisplayName("Customer Region"), Expression("jCustomer.[Region]")]
        public String CustomerRegion
        {
            get { return Fields.CustomerRegion[this]; }
            set { Fields.CustomerRegion[this] = value; }
        }

        [DisplayName("Customer Postal Code"), Expression("jCustomer.[PostalCode]")]
        public String CustomerPostalCode
        {
            get { return Fields.CustomerPostalCode[this]; }
            set { Fields.CustomerPostalCode[this] = value; }
        }

        [DisplayName("Customer Country"), Expression("jCustomer.[Country]")]
        public String CustomerCountry
        {
            get { return Fields.CustomerCountry[this]; }
            set { Fields.CustomerCountry[this] = value; }
        }

        [DisplayName("Customer Phone"), Expression("jCustomer.[Phone]")]
        public String CustomerPhone
        {
            get { return Fields.CustomerPhone[this]; }
            set { Fields.CustomerPhone[this] = value; }
        }

        [DisplayName("Customer Fax"), Expression("jCustomer.[Fax]")]
        public String CustomerFax
        {
            get { return Fields.CustomerFax[this]; }
            set { Fields.CustomerFax[this] = value; }
        }

        [DisplayName("Customer Id"), Expression("jCustomer.[ID]")]
        public Int32? CustomerId1
        {
            get { return Fields.CustomerId1[this]; }
            set { Fields.CustomerId1[this] = value; }
        }

        [DisplayName("Prioridad"), Expression("jPriority.[PriorityDescription]")]
        public String PriorityPriorityDescription
        {
            get { return Fields.PriorityPriorityDescription[this]; }
            set { Fields.PriorityPriorityDescription[this] = value; }
        }

        [DisplayName("Details"), MasterDetailRelation(foreignKey: "ProjectId"), NotMapped]
        public List<ProjectDetailsRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }

        [Origin("ds")]
        public Boolean? Blueprints
        {
            get { return Fields.Blueprints[this]; }
            set { Fields.Blueprints[this] = value; }
        }

        [Origin("ds") ]
        public Boolean? PorposalFirst
        {
            get { return Fields.PorposalFirst[this]; }
            set { Fields.PorposalFirst[this] = value; }
        }

        [Origin("ds") ]
        public Boolean? Measures
        {
            get { return Fields.Measures[this]; }
            set { Fields.Measures[this] = value; }
        }

        [Origin("ds")]
        public Boolean? Corrections
        {
            get { return Fields.Corrections[this]; }
            set { Fields.Corrections[this] = value; }
        }

        [Origin("ds")]
        public Boolean? PorposalFinal
        {
            get { return Fields.PorposalFinal[this]; }
            set { Fields.PorposalFinal[this] = value; }
        }


        IIdField IIdRow.IdField
        {
            get { return Fields.ProjectID; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CustomerId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProjectsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProjectID;
            public StringField CustomerId;
            public StringField ProjectName;
            public StringField Description;
            public DateTimeField RequiredDate;
            public Int32Field PriorityId;
            public BooleanField Aproved;

            public StringField CustomerCompanyName;
            public StringField CustomerContactName;
            public StringField CustomerContactTitle;
            public StringField CustomerAddress;
            public StringField CustomerCity;
            public StringField CustomerRegion;
            public StringField CustomerPostalCode;
            public StringField CustomerCountry;
            public StringField CustomerPhone;
            public StringField CustomerFax;
            public Int32Field CustomerId1;

            public StringField PriorityPriorityDescription;
            public RowListField<ProjectDetailsRow> DetailList;
            public BooleanField Blueprints;
            public BooleanField PorposalFirst;
            public BooleanField Measures;
            public BooleanField Corrections;
            public BooleanField PorposalFinal;

        }
    }
}
