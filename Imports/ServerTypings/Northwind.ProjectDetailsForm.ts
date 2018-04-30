namespace Miapp2.Northwind {
    export interface ProjectDetailsForm {
        DesignTypeId: Serenity.LookupEditor;
        Width: Serenity.DecimalEditor;
        High: Serenity.DecimalEditor;
        Deep: Serenity.DecimalEditor;
        Observaciones: Serenity.StringEditor;
    }

    export class ProjectDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.ProjectDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProjectDetailsForm.init)  {
                ProjectDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.StringEditor;

                Q.initFormType(ProjectDetailsForm, [
                    'DesignTypeId', w0,
                    'Width', w1,
                    'High', w1,
                    'Deep', w1,
                    'Observaciones', w2
                ]);
            }
        }
    }
}
