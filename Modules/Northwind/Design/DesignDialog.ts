
namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class DesignDialog extends Serenity.EntityDialog<DesignRow, any> {
        protected getFormKey() { return DesignForm.formKey; }
        protected getIdProperty() { return DesignRow.idProperty; }
        protected getLocalTextPrefix() { return DesignRow.localTextPrefix; }
        protected getService() { return DesignService.baseUrl; }

        protected form = new DesignForm(this.idPrefix);

    }
}