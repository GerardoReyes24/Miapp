
namespace Miapp2.Registros {

    @Serenity.Decorators.registerClass()
    export class RegistrosGrid extends Serenity.EntityGrid<RegistrosRow, any> {
        protected getColumnsKey() { return 'Registros.Registros'; }
        protected getDialogType() { return RegistrosDialog; }
        protected getIdProperty() { return RegistrosRow.idProperty; }
        protected getLocalTextPrefix() { return RegistrosRow.localTextPrefix; }
        protected getService() { return RegistrosService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}