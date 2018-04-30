
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class DesignTypeDialog extends Serenity.EntityDialog<DesignTypeRow, any> {
        protected getFormKey() { return DesignTypeForm.formKey; }
        protected getIdProperty() { return DesignTypeRow.idProperty; }
        protected getLocalTextPrefix() { return DesignTypeRow.localTextPrefix; }
        protected getNameProperty() { return DesignTypeRow.nameProperty; }
        protected getService() { return DesignTypeService.baseUrl; }

        protected form = new DesignTypeForm(this.idPrefix);

    }
}