namespace Miapp2.Northwind {
    export interface TipoMuebleForm {
        MuebleName: Serenity.StringEditor;
        MuebleDescription: Serenity.StringEditor;
    }

    export class TipoMuebleForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.TipoMueble';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TipoMuebleForm.init)  {
                TipoMuebleForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(TipoMuebleForm, [
                    'MuebleName', w0,
                    'MuebleDescription', w0
                ]);
            }
        }
    }
}
