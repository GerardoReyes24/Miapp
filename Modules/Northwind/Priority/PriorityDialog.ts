
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class PriorityDialog extends Serenity.EntityDialog<PriorityRow, any> {
        protected getFormKey() { return PriorityForm.formKey; }
        protected getIdProperty() { return PriorityRow.idProperty; }
        protected getLocalTextPrefix() { return PriorityRow.localTextPrefix; }
        protected getNameProperty() { return PriorityRow.nameProperty; }
        protected getService() { return PriorityService.baseUrl; }

        protected form = new PriorityForm(this.idPrefix);

    }
}