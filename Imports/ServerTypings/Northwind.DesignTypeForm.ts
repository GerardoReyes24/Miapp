namespace Miapp2.Northwind {
    export interface DesignTypeForm {
        DesType: Serenity.StringEditor;
    }

    export class DesignTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.DesignType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DesignTypeForm.init)  {
                DesignTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(DesignTypeForm, [
                    'DesType', w0
                ]);
            }
        }
    }
}
