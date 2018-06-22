

namespace Miapp2.Northwind.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("Suppliers")]
    [DisplayName("Suppliers"), InstanceName("Supplier")]
    [ReadPermission(PermissionKeys.General)]
    [ModifyPermission(PermissionKeys.General)]
    [LookupScript]
    public sealed class SupplierRow : Row, IIdRow, INameRow
    {
        [DisplayName("Clave"), Identity]
        public Int32? SupplierID
        {
            get { return Fields.SupplierID[this]; }
            set { Fields.SupplierID[this] = value; }
        }

        [DisplayName("Empresa"), Size(40), NotNull, QuickSearch]
        public String CompanyName
        {
            get { return Fields.CompanyName[this]; }
            set { Fields.CompanyName[this] = value; }
        }

        [DisplayName("Nombre de contacto"), Size(30)]
        public String ContactName
        {
            get { return Fields.ContactName[this]; }
            set { Fields.ContactName[this] = value; }
        }

       

        [DisplayName("Dirección"), Size(60)]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

     

 

       


      

     

        IIdField IIdRow.IdField
        {
            get { return Fields.SupplierID; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CompanyName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SupplierRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field SupplierID;
            public StringField CompanyName;
            public StringField ContactName;
           
            public StringField Address;
      
        }
    }
}