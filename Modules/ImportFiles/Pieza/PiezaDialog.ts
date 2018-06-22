
namespace Miapp2.ImportFiles {

    @Serenity.Decorators.registerClass()
    export class PiezaDialog extends Serenity.EntityDialog<PiezaRow, any> {
        protected getFormKey() { return PiezaForm.formKey; }
        protected getIdProperty() { return PiezaRow.idProperty; }
        protected getLocalTextPrefix() { return PiezaRow.localTextPrefix; }
        protected getNameProperty() { return PiezaRow.nameProperty; }
        protected getService() { return PiezaService.baseUrl; }

        protected form = new PiezaForm(this.idPrefix);

    }
}