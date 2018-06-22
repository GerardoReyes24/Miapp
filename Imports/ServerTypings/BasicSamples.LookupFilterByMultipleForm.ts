﻿namespace Miapp2.BasicSamples {
    export interface LookupFilterByMultipleForm {
        ProductName: Serenity.StringEditor;
        ProductImage: Serenity.ImageUploadEditor;
        Discontinued: Serenity.BooleanEditor;
        SupplierID: Serenity.LookupEditor;
        CategoryID: ProduceSeafoodCategoryEditor;
        UnitPrice: Serenity.DecimalEditor;
        UnitsInStock: Serenity.IntegerEditor;
    }

    export class LookupFilterByMultipleForm extends Serenity.PrefixedContext {
        static formKey = 'BasicSamples.LookupFilterByMultiple';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LookupFilterByMultipleForm.init)  {
                LookupFilterByMultipleForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;
                var w2 = s.BooleanEditor;
                var w3 = s.LookupEditor;
                var w4 = ProduceSeafoodCategoryEditor;
                var w5 = s.DecimalEditor;
                var w6 = s.IntegerEditor;

                Q.initFormType(LookupFilterByMultipleForm, [
                    'ProductName', w0,
                    'ProductImage', w1,
                    'Discontinued', w2,
                    'SupplierID', w3,
                    'CategoryID', w4,
                    'UnitPrice', w5,
                    'UnitsInStock', w6
                ]);
            }
        }
    }
}
