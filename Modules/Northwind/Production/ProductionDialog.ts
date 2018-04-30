
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class ProductionDialog extends Serenity.EntityDialog<ProductionRow, any> {
        protected getFormKey() { return ProductionForm.formKey; }
        protected getIdProperty() { return ProductionRow.idProperty; }
        protected getLocalTextPrefix() { return ProductionRow.localTextPrefix; }
        protected getService() { return ProductionService.baseUrl; }

        protected form = new ProductionForm(this.idPrefix);

    }
}