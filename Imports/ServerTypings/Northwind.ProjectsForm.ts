namespace Miapp2.Northwind {
    export interface ProjectsForm {
        CustomerId: Serenity.LookupEditor;
        ProjectName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        RequiredDate: Serenity.DateEditor;
        PriorityId: Serenity.LookupEditor;
        Aproved: Serenity.BooleanEditor;
        DetailList: ProjectDetailsEditor;
        Blueprints: Serenity.BooleanEditor;
        PorposalFirst: Serenity.BooleanEditor;
        Measures: Serenity.BooleanEditor;
        Corrections: Serenity.BooleanEditor;
        PorposalFinal: Serenity.BooleanEditor;
    }

    export class ProjectsForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.Projects';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProjectsForm.init)  {
                ProjectsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;
                var w3 = s.BooleanEditor;
                var w4 = ProjectDetailsEditor;

                Q.initFormType(ProjectsForm, [
                    'CustomerId', w0,
                    'ProjectName', w1,
                    'Description', w1,
                    'RequiredDate', w2,
                    'PriorityId', w0,
                    'Aproved', w3,
                    'DetailList', w4,
                    'Blueprints', w3,
                    'PorposalFirst', w3,
                    'Measures', w3,
                    'Corrections', w3,
                    'PorposalFinal', w3
                ]);
            }
        }
    }
}
