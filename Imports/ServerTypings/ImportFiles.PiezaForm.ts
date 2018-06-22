namespace Miapp2.ImportFiles {
    export interface PiezaForm {
        Pieza: Serenity.StringEditor;
        GrosTab: Serenity.DecimalEditor;
        Enchapado: Serenity.StringEditor;
        MtsEnchapado: Serenity.DecimalEditor;
        MtsCorte: Serenity.DecimalEditor;
    }

    export class PiezaForm extends Serenity.PrefixedContext {
        static formKey = 'ImportFiles.Pieza';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PiezaForm.init)  {
                PiezaForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;

                Q.initFormType(PiezaForm, [
                    'Pieza', w0,
                    'GrosTab', w1,
                    'Enchapado', w0,
                    'MtsEnchapado', w1,
                    'MtsCorte', w1
                ]);
            }
        }
    }
}
