namespace Miapp2.Northwind {
    export interface RUbicacionForm {
        RUbicacionN: Serenity.StringEditor;
        RUbicacionDesc: Serenity.StringEditor;
    }

    export class RUbicacionForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.RUbicacion';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RUbicacionForm.init)  {
                RUbicacionForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(RUbicacionForm, [
                    'RUbicacionN', w0,
                    'RUbicacionDesc', w0
                ]);
            }
        }
    }
}
