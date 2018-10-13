namespace Miapp2.Northwind {
    export interface NoCasaForm {
        NumeroCasa: Serenity.StringEditor;
    }

    export class NoCasaForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.NoCasa';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!NoCasaForm.init)  {
                NoCasaForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(NoCasaForm, [
                    'NumeroCasa', w0
                ]);
            }
        }
    }
}
