namespace Miapp2.Northwind {
    export interface PriorityForm {
        PriorityId: Serenity.IntegerEditor;
        PriorityDescription: Serenity.StringEditor;
    }

    export class PriorityForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.Priority';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PriorityForm.init)  {
                PriorityForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;

                Q.initFormType(PriorityForm, [
                    'PriorityId', w0,
                    'PriorityDescription', w1
                ]);
            }
        }
    }
}
