﻿namespace Miapp2.Registros {
    export interface RegistrosForm {
        Fecha: Serenity.DateEditor;
        ProductId: Serenity.LookupEditor;
        Cantidad: Serenity.DecimalEditor;
        Movimiento: Serenity.EnumEditor;
        NoOrder: Serenity.StringEditor;
        DetailID: Serenity.LookupEditor;
        ProjectID: Serenity.LookupEditor;
    }

    export class RegistrosForm extends Serenity.PrefixedContext {
        static formKey = 'Registros.Registros';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RegistrosForm.init)  {
                RegistrosForm.init = true;

                var s = Serenity;
                var w0 = s.DateEditor;
                var w1 = s.LookupEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.EnumEditor;
                var w4 = s.StringEditor;

                Q.initFormType(RegistrosForm, [
                    'Fecha', w0,
                    'ProductId', w1,
                    'Cantidad', w2,
                    'Movimiento', w3,
                    'NoOrder', w4,
                    'DetailID', w1,
                    'ProjectID', w1
                ]);
            }
        }
    }
}
