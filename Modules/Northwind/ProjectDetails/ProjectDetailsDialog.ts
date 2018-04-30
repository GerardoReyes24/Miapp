
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class ProjectDetailsDialog extends Common.GridEditorDialog<ProjectDetailsRow> {
        protected getFormKey() { return ProjectDetailsForm.formKey; }
        protected getLocalTextPrefix() { return ProjectDetailsRow.localTextPrefix; }
    
        protected form: ProjectDetailsForm;

        constructor() {

            super();

            this.form = new ProjectDetailsForm(this.idPrefix);




        }

    }
}