
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class RUbicacionGrid extends Serenity.EntityGrid<RUbicacionRow, any> {
        protected getColumnsKey() { return 'Northwind.RUbicacion'; }
        protected getDialogType() { return RUbicacionDialog; }
        protected getIdProperty() { return RUbicacionRow.idProperty; }
        protected getLocalTextPrefix() { return RUbicacionRow.localTextPrefix; }
        protected getService() { return RUbicacionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}