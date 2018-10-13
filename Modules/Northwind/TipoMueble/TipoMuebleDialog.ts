
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class TipoMuebleDialog extends Serenity.EntityDialog<TipoMuebleRow, any> {
        protected getFormKey() { return TipoMuebleForm.formKey; }
        protected getIdProperty() { return TipoMuebleRow.idProperty; }
        protected getLocalTextPrefix() { return TipoMuebleRow.localTextPrefix; }
        protected getNameProperty() { return TipoMuebleRow.nameProperty; }
        protected getService() { return TipoMuebleService.baseUrl; }

        protected form = new TipoMuebleForm(this.idPrefix);

    }
}