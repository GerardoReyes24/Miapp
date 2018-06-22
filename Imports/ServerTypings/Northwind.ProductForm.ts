namespace Miapp2.Northwind {
    export interface ProductForm {
        ProductID: Serenity.StringEditor;
        ProductName: Serenity.StringEditor;
        ProductImage: Serenity.ImageUploadEditor;
        Discontinued: Serenity.BooleanEditor;
        SupplierID: Serenity.LookupEditor;
        CategoryID: Serenity.LookupEditor;
        UnitPrice: Serenity.DecimalEditor;
        UnitsInStock: Serenity.IntegerEditor;
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
                var w2 = s.BooleanEditor;
                var w3 = s.LookupEditor;
                var w4 = s.DecimalEditor;
                var w5 = s.IntegerEditor;

                Q.initFormType(ProductForm, [
                    'ProductID', w0,
                    'ProductName', w0,
                    'ProductImage', w1,
                    'Discontinued', w2,
                    'SupplierID', w3,
                    'CategoryID', w3,
                    'UnitPrice', w4,
                    'UnitsInStock', w5
                ]);
            }
        }
    }
}
