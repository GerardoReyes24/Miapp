/// <reference path="../../../Northwind/Supplier/SupplierDialog.ts" />

namespace Miapp2.BasicSamples {

    @Serenity.Decorators.registerClass()
    export class ReadOnlyDialog extends Northwind.SupplierDialog {

        protected getToolbarButtons(): Serenity.ToolButton[] {
            let buttons = super.getToolbarButtons();

            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "save-and-close-button"), 1);
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "apply-changes-button"), 1);

            // We could also remove delete button here, but for demonstration 
            // purposes we'll hide it in another method (updateInterface)
            // buttons.splice(Q.indexOf(buttons, x => x.cssClass == "delete-button"), 1);

            return buttons;
        }

        protected updateInterface(): void {

            super.updateInterface();


            Serenity.EditorUtils.setReadonly(this.element.find('.editor'), true);

       
            this.element.find('sup').hide();


            this.deleteButton.hide();

        
        }

       
        protected getEntityTitle(): string {

            if (!this.isEditMode()) {
           
                return "How did you manage to open this dialog in new record mode?";
            }
            else {
               
                var entityType = super.getEntitySingular();

                // get name field value of record this dialog edits
                let name = this.getEntityNameFieldValue() || "";

                // you could use Q.format with a local text, but again demo...
                return 'View ' + entityType + " (" + name + ")";
            }
        }

    
        protected updateTitle(): void {
            super.updateTitle();

        }

    }
}