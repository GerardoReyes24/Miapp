
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class RUbicacionDialog extends Serenity.EntityDialog<RUbicacionRow, any> {
        protected getFormKey() { return RUbicacionForm.formKey; }
        protected getIdProperty() { return RUbicacionRow.idProperty; }
        protected getLocalTextPrefix() { return RUbicacionRow.localTextPrefix; }
        protected getNameProperty() { return RUbicacionRow.nameProperty; }
        protected getService() { return RUbicacionService.baseUrl; }

        protected form = new RUbicacionForm(this.idPrefix);

    }
}