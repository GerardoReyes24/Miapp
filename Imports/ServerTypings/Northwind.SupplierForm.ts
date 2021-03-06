﻿namespace Miapp2.Northwind {
    export interface SupplierForm {
        CompanyName: Serenity.StringEditor;
        ContactName: Serenity.StringEditor;
        Address: Serenity.StringEditor;
    }

    export class SupplierForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.Supplier';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SupplierForm.init)  {
                SupplierForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(SupplierForm, [
                    'CompanyName', w0,
                    'ContactName', w0,
                    'Address', w0
                ]);
            }
        }
    }
}
