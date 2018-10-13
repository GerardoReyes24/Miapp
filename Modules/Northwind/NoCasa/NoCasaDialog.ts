
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class NoCasaDialog extends Serenity.EntityDialog<NoCasaRow, any> {
        protected getFormKey() { return NoCasaForm.formKey; }
        protected getIdProperty() { return NoCasaRow.idProperty; }
        protected getLocalTextPrefix() { return NoCasaRow.localTextPrefix; }
        protected getNameProperty() { return NoCasaRow.nameProperty; }
        protected getService() { return NoCasaService.baseUrl; }

        protected form = new NoCasaForm(this.idPrefix);

    }
}