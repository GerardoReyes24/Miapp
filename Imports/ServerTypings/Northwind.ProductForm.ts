namespace Miapp2.Northwind {
    export interface ProductForm {
        ProductID: Serenity.StringEditor;
        Product2ID: Serenity.StringEditor;
        ProductName: Serenity.StringEditor;
        ProductImage: Serenity.ImageUploadEditor;
        SupplierID: Serenity.LookupEditor;
        CategoryID: Serenity.LookupEditor;
        UnitPrice: Serenity.DecimalEditor;
        UnitsInStock: Serenity.DecimalEditor;
        QuantityPerUnit: Serenity.StringEditor;
    }

    export class ProductForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.Product';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductForm.init)  {
                ProductForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;
                var w2 = s.LookupEditor;
                var w3 = s.DecimalEditor;

                Q.initFormType(ProductForm, [
                    'ProductID', w0,
                    'Product2ID', w0,
                    'ProductName', w0,
                    'ProductImage', w1,
                    'SupplierID', w2,
                    'CategoryID', w2,
                    'UnitPrice', w3,
                    'UnitsInStock', w3,
                    'QuantityPerUnit', w0
                ]);
            }
        }
    }
}
