
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class ProductionGrid extends Serenity.EntityGrid<ProductionRow, any> {
        protected getColumnsKey() { return 'Northwind.Production'; }
        protected getDialogType() { return ProductionDialog; }
        protected getIdProperty() { return ProductionRow.idProperty; }
        protected getLocalTextPrefix() { return ProductionRow.localTextPrefix; }
        protected getService() { return ProductionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}