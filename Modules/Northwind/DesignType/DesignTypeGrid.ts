
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class DesignTypeGrid extends Serenity.EntityGrid<DesignTypeRow, any> {
        protected getColumnsKey() { return 'Northwind.DesignType'; }
        protected getDialogType() { return DesignTypeDialog; }
        protected getIdProperty() { return DesignTypeRow.idProperty; }
        protected getLocalTextPrefix() { return DesignTypeRow.localTextPrefix; }
        protected getService() { return DesignTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}