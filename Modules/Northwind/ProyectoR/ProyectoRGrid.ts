
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class ProyectoRGrid extends Serenity.EntityGrid<ProyectoRRow, any> {
        protected getColumnsKey() { return 'Northwind.ProyectoR'; }
        protected getDialogType() { return ProyectoRDialog; }
        protected getIdProperty() { return ProyectoRRow.idProperty; }
        protected getLocalTextPrefix() { return ProyectoRRow.localTextPrefix; }
        protected getService() { return ProyectoRService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}