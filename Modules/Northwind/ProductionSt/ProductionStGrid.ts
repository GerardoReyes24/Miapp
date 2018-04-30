
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class ProductionStGrid extends Serenity.EntityGrid<ProductionStRow, any> {
        protected getColumnsKey() { return 'Northwind.ProductionSt'; }
        protected getDialogType() { return ProductionStDialog; }
        protected getIdProperty() { return ProductionStRow.idProperty; }
        protected getLocalTextPrefix() { return ProductionStRow.localTextPrefix; }
        protected getService() { return ProductionStService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}