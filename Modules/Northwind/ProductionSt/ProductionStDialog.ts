
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class ProductionStDialog extends Serenity.EntityDialog<ProductionStRow, any> {
        protected getFormKey() { return ProductionStForm.formKey; }
        protected getIdProperty() { return ProductionStRow.idProperty; }
        protected getLocalTextPrefix() { return ProductionStRow.localTextPrefix; }
        protected getService() { return ProductionStService.baseUrl; }

        protected form = new ProductionStForm(this.idPrefix);

    }
}