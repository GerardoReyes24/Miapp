
namespace Miapp2.ImportFiles {

    @Serenity.Decorators.registerClass()
    export class PruebaGrid extends Serenity.EntityGrid<PruebaRow, any> {
        protected getColumnsKey() { return 'ImportFiles.Prueba'; }
        protected getDialogType() { return PruebaDialog; }
        protected getIdProperty() { return PruebaRow.idProperty; }
        protected getLocalTextPrefix() { return PruebaRow.localTextPrefix; }
        protected getService() { return PruebaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons(): Serenity.ToolButton[] {

            
            var buttons = super.getButtons();

           
            buttons.push({
                title: 'Import From Excel',
                cssClass: 'export-xlsx-button',
                onClick: () => {

                    var dialog = new BasicSamples.ProductExcelImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                    dialog.dialogOpen();
                }
            });

            return buttons;
        }



    }
}