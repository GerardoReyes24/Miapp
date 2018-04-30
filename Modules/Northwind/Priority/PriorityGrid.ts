
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class PriorityGrid extends Serenity.EntityGrid<PriorityRow, any> {
        protected getColumnsKey() { return 'Northwind.Priority'; }
        protected getDialogType() { return PriorityDialog; }
        protected getIdProperty() { return PriorityRow.idProperty; }
        protected getLocalTextPrefix() { return PriorityRow.localTextPrefix; }
        protected getService() { return PriorityService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}