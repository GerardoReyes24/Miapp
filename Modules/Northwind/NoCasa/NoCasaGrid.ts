
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class NoCasaGrid extends Serenity.EntityGrid<NoCasaRow, any> {
        protected getColumnsKey() { return 'Northwind.NoCasa'; }
        protected getDialogType() { return NoCasaDialog; }
        protected getIdProperty() { return NoCasaRow.idProperty; }
        protected getLocalTextPrefix() { return NoCasaRow.localTextPrefix; }
        protected getService() { return NoCasaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}