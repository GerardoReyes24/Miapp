
namespace Miapp2.Registros {

    @Serenity.Decorators.registerClass()
    export class MuestreosDialog extends Serenity.EntityDialog<MuestreosRow, any> {
        protected getFormKey() { return MuestreosForm.formKey; }
        protected getIdProperty() { return MuestreosRow.idProperty; }
        protected getLocalTextPrefix() { return MuestreosRow.localTextPrefix; }
        protected getNameProperty() { return MuestreosRow.nameProperty; }
        protected getService() { return MuestreosService.baseUrl; }

        protected form = new MuestreosForm(this.idPrefix);

    }
}