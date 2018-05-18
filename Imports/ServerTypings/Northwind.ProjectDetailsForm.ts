namespace Miapp2.Northwind {
    export interface ProjectDetailsForm {
        DesignTypeId: Serenity.LookupEditor;
        Width: Serenity.DecimalEditor;
        High: Serenity.DecimalEditor;
        Deep: Serenity.DecimalEditor;
        Observaciones: Serenity.TextAreaEditor;
        Cutter: Serenity.EnumEditor;
        Cnc: Serenity.EnumEditor;
        Plating: Serenity.EnumEditor;
        Detailed: Serenity.EnumEditor;
        Armed: Serenity.EnumEditor;
        Packed: Serenity.EnumEditor;
        Installed: Serenity.EnumEditor;
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
                var w2 = s.TextAreaEditor;
                var w3 = s.EnumEditor;

                Q.initFormType(ProjectDetailsForm, [
                    'DesignTypeId', w0,
                    'Width', w1,
                    'High', w1,
                    'Deep', w1,
                    'Observaciones', w2,
                    'Cutter', w3,
                    'Cnc', w3,
                    'Plating', w3,
                    'Detailed', w3,
                    'Armed', w3,
                    'Packed', w3,
                    'Installed', w3
                ]);
            }
        }
    }
}
