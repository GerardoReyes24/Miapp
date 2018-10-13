
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class ProyectoRDialog extends Serenity.EntityDialog<ProyectoRRow, any> {
        protected getFormKey() { return ProyectoRForm.formKey; }
        protected getIdProperty() { return ProyectoRRow.idProperty; }
        protected getLocalTextPrefix() { return ProyectoRRow.localTextPrefix; }
        protected getNameProperty() { return ProyectoRRow.nameProperty; }
        protected getService() { return ProyectoRService.baseUrl; }

        protected form = new ProyectoRForm(this.idPrefix);

    }
}