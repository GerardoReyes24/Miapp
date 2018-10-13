namespace Miapp2.Northwind {
    export interface ProyectoRForm {
        ProyectorName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    export class ProyectoRForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.ProyectoR';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProyectoRForm.init)  {
                ProyectoRForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(ProyectoRForm, [
                    'ProyectorName', w0,
                    'Description', w0
                ]);
            }
        }
    }
}
