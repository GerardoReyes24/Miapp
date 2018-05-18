
namespace Miapp2.ImportFiles {

    @Serenity.Decorators.registerClass()
    export class PruebaDialog extends Serenity.EntityDialog<PruebaRow, any> {
        protected getFormKey() { return PruebaForm.formKey; }
        protected getIdProperty() { return PruebaRow.idProperty; }
        protected getLocalTextPrefix() { return PruebaRow.localTextPrefix; }
        protected getNameProperty() { return PruebaRow.nameProperty; }
        protected getService() { return PruebaService.baseUrl; }

        protected form = new PruebaForm(this.idPrefix);

    }
}