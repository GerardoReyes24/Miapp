
namespace Miapp2.Registros {

    @Serenity.Decorators.registerClass()
    export class RegistrosDialog extends Serenity.EntityDialog<RegistrosRow, any> {
        protected getFormKey() { return RegistrosForm.formKey; }
        protected getIdProperty() { return RegistrosRow.idProperty; }
        protected getLocalTextPrefix() { return RegistrosRow.localTextPrefix; }
        protected getNameProperty() { return RegistrosRow.nameProperty; }
        protected getService() { return RegistrosService.baseUrl; }

        protected form = new RegistrosForm(this.idPrefix);

        constructor() {
            super();

            this.toolbar.findButton(".delete-button").remove();
        }

      
      
    }
}