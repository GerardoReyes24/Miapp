
namespace Miapp2.ImportFiles {

    @Serenity.Decorators.registerClass()
    export class PiezaGrid extends Serenity.EntityGrid<PiezaRow, any> {
        protected getColumnsKey() { return 'ImportFiles.Pieza'; }
        protected getDialogType() { return PiezaDialog; }
        protected getIdProperty() { return PiezaRow.idProperty; }
        protected getLocalTextPrefix() { return PiezaRow.localTextPrefix; }
        protected getService() { return PiezaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);

            this.toolbar.findButton(".column-picker-button").remove();
            this.toolbar.findButton(".refresh-button").remove();
            this.toolbar.findButton(".add-button").remove();
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

            buttons.push({
                title: 'Borrar',
                cssClass: 'delete-button',
                onClick: () => {
                    PiezaService.resultt({
                    }, response => {
                        Q.alert("true");
                        })
                }

            });
    


            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: PiezaService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: true
            }));

     

            return buttons;
        }
    }
}