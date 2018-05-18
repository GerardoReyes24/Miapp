namespace Miapp2.ImportFiles {
    export interface PruebaForm {
        Type1: Serenity.StringEditor;
        Type2: Serenity.IntegerEditor;
        Type3: Serenity.DecimalEditor;
    }

    export class PruebaForm extends Serenity.PrefixedContext {
        static formKey = 'ImportFiles.Prueba';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PruebaForm.init)  {
                PruebaForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;

                Q.initFormType(PruebaForm, [
                    'Type1', w0,
                    'Type2', w1,
                    'Type3', w2
                ]);
            }
        }
    }
}
