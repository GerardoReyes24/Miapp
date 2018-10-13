
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class TipoMuebleGrid extends Serenity.EntityGrid<TipoMuebleRow, any> {
        protected getColumnsKey() { return 'Northwind.TipoMueble'; }
        protected getDialogType() { return TipoMuebleDialog; }
        protected getIdProperty() { return TipoMuebleRow.idProperty; }
        protected getLocalTextPrefix() { return TipoMuebleRow.localTextPrefix; }
        protected getService() { return TipoMuebleService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}