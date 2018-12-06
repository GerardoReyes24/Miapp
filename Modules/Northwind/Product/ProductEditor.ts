namespace Miapp2.Northwind {

    @Serenity.Decorators.registerEditor()
    export class ProductEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, ProductRow> {

        constructor(hidden: JQuery) {
            super(hidden);
        }

        protected getLookupKey() {
            return 'Northwind.Product';
        }

        protected getItemText(item, lookup) {
            return super.getItemText(item, lookup) + ' [' + item.ProductID + ']';
        }
    }
}