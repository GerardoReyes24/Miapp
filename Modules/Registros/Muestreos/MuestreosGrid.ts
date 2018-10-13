
namespace Miapp2.Registros {

    @Serenity.Decorators.registerClass()
    export class MuestreosGrid extends Serenity.EntityGrid<MuestreosRow, any> {
        protected getColumnsKey() { return 'Registros.Muestreos'; }
        protected getDialogType() { return MuestreosDialog; }
        protected getIdProperty() { return MuestreosRow.idProperty; }
        protected getLocalTextPrefix() { return MuestreosRow.localTextPrefix; }
        protected getService() { return MuestreosService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }



        protected getButtons() {
            var buttons = super.getButtons();

            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: MuestreosService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: true
            }));

            buttons.push(Common.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit(),
                reportTitle: 'Reporte Muestreos',
                columnTitles: {
                    'Discontinued': 'Dis.',
                },
                tableOptions: {
                    columnStyles: {
                        ProductID: {
                            columnWidth: 25,
                            halign: 'right'
                        },
                        Discountinued: {
                            columnWidth: 25
                        }
                    }
                }
            }));

        



            return buttons;
        }

  
    }
}