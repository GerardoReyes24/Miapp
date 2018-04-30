namespace Miapp2.Northwind {
    export interface DesignForm {
        Date: Serenity.DateEditor;
        DesignTypeId: Serenity.LookupEditor;
        DesignTime: Serenity.DecimalEditor;
        DesignInTime: Serenity.BooleanEditor;
        Aproved: Serenity.BooleanEditor;
    }

    export class DesignForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.Design';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DesignForm.init)  {
                DesignForm.init = true;

                var s = Serenity;
                var w0 = s.DateEditor;
                var w1 = s.LookupEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(DesignForm, [
                    'Date', w0,
                    'DesignTypeId', w1,
                    'DesignTime', w2,
                    'DesignInTime', w3,
                    'Aproved', w3
                ]);
            }
        }
    }
}
