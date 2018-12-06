
namespace Miapp2.Northwind.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Northwind"), Module("Northwind"), TableName("Products")]
    [DisplayName("Materiales"), InstanceName("Product")]
    [ReadPermission(PermissionKeys.Materiales.View)]
    [ModifyPermission(PermissionKeys.Materiales.Modify)]
    [DeletePermission(PermissionKeys.Materiales.Delete)]
    [LookupScript("Some.Lookup", Permission = "?")]


    [LocalizationRow(typeof(ProductLangRow))]
    public sealed class ProductRow : Row, IIdRow, INameRow
    {
        [DisplayName("Código Interno"),PrimaryKey,NotNull, LookupInclude, QuickSearch]
        [ReadPermission(" SomeSpecialPermission "), ModifyPermission(" SomeSpecialPermission ")]
        public String ProductID
        {
            get { return Fields.ProductID[this]; }
            set { Fields.ProductID[this] = value; }

        }


        [DisplayName("Código externo"), QuickSearch, ReadPermission(" SomeSpecialPermission ")]
        public String Product2ID
        {
            get { return Fields.Product2ID[this]; }
            set { Fields.Product2ID[this] = value; }
        }

        [DisplayName("Descripción"), Size(40), NotNull, QuickSearch,  LookupInclude]
        [ReadPermission(" SomeSpecialPermission ")]
        public String ProductName
        {
            get { return Fields.ProductName[this]; }
            set { Fields.ProductName[this] = value; }
        }

        [DisplayName("Cantidad Por Unidad"), Size(100), ]
        [ReadPermission(" SomeSpecialPermission ")]
        public String QuantityPerUnit
        {
            get { return Fields.QuantityPerUnit[this]; }
            set { Fields.QuantityPerUnit[this] = value; }
        }

        [DisplayName("Imagen"), Size(100)]
        [ImageUploadEditor(FilenameFormat = "ProductImage/~", CopyToHistory = true)]
        public String ProductImage
        {
            get { return Fields.ProductImage[this]; }
            set { Fields.ProductImage[this] = value; }
        }

        [DisplayName("Existencia"), NotNull]
        public Boolean? Discontinued
        {
            get { return Fields.Discontinued[this]; }
            set { Fields.Discontinued[this] = value; }
        }

        [DisplayName("Proveedor"), ForeignKey(typeof(SupplierRow)), LeftJoin("sup")]
        [LookupEditor(typeof(SupplierRow), InplaceAdd = true)]
        public Int32? SupplierID
        {
            get { return Fields.SupplierID[this]; }
            set { Fields.SupplierID[this] = value; }
        }

        [DisplayName("Categoria"), ForeignKey(typeof(CategoryRow)), LeftJoin("cat"), LookupInclude]
        [LookupEditor(typeof(CategoryRow), InplaceAdd = true)]
        public Int32? CategoryID
        {
            get { return Fields.CategoryID[this]; }
            set { Fields.CategoryID[this] = value; }
        }

     

        [DisplayName("Precio unitario"), Scale(9)]
        public Decimal? UnitPrice
        {
            get { return Fields.UnitPrice[this]; }
            set { Fields.UnitPrice[this] = value; }
        }

        [DisplayName("Cantidad en existencia"), NotNull, DefaultValue(0)]
        [ModifyPermission(" SomeSpecialPermission ")]
        public Int16? UnitsInStock
        {
            get { return Fields.UnitsInStock[this]; }
            set { Fields.UnitsInStock[this] = value; }
        }

        


        [Origin("sup"), DisplayName("Proveedor"), LookupInclude]
        public String SupplierCompanyName
        {
            get { return Fields.SupplierCompanyName[this]; }
            set { Fields.SupplierCompanyName[this] = value; }
        }

        [Origin("sup")]
        public String SupplierContactName
        {
            get { return Fields.SupplierContactName[this]; }
            set { Fields.SupplierContactName[this] = value; }
        }

   

        [Origin("sup")]
        public String SupplierAddress
        {
            get { return Fields.SupplierAddress[this]; }
            set { Fields.SupplierAddress[this] = value; }
        }

    


 

  

 
      

    

        [Origin("cat"), DisplayName("Categoría")]
        public String CategoryName
        {
            get { return Fields.CategoryName[this]; }
            set { Fields.CategoryName[this] = value; }
        }

        [Origin("cat")]
        public String CategoryDescription
        {
            get { return Fields.CategoryDescription[this]; }
            set { Fields.CategoryDescription[this] = value; }
        }

        [Origin("cat")]
        public Stream CategoryPicture
        {
            get { return Fields.CategoryPicture[this]; }
            set { Fields.CategoryPicture[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ProductID; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ProductName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField ProductID;
            public StringField Product2ID;
            public StringField ProductName;
            public StringField ProductImage;
            public BooleanField Discontinued;
            public Int32Field SupplierID;
            public Int32Field CategoryID;
 
            public DecimalField UnitPrice;
            public Int16Field UnitsInStock;
    
            public StringField SupplierCompanyName;
            public StringField SupplierContactName;
    
            public StringField SupplierAddress;
    
    

            public StringField CategoryName;
            public StringField QuantityPerUnit;
            public StringField CategoryDescription;
            public StreamField CategoryPicture;
        }
    }
}