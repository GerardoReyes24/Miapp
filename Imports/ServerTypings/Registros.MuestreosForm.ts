namespace Miapp2.Registros {
    export interface MuestreosForm {
        Fecha: Serenity.DateEditor;
        ProductId: Serenity.LookupEditor;
        CantidadAMuestrear: Serenity.DecimalEditor;
    }

    export class MuestreosForm extends Serenity.PrefixedContext {
        static formKey = 'Registros.Muestreos';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MuestreosForm.init)  {
                MuestreosForm.init = true;

                var s = Serenity;
                var w0 = s.DateEditor;
                var w1 = s.LookupEditor;
                var w2 = s.DecimalEditor;

                Q.initFormType(MuestreosForm, [
                    'Fecha', w0,
                    'ProductId', w1,
                    'CantidadAMuestrear', w2
                ]);
            }
        }
    }
}
