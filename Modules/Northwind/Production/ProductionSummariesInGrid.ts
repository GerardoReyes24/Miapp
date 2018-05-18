/// <reference path="ProductionGrid.ts" />

namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()


    export class ProductionSummariesInGrid extends Northwind.ProductionGrid {

        constructor(container: JQuery) {
            super(container);
        }


        protected getButtons() {
            var buttons = super.getButtons();

            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: ProductService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: true
            }));

            buttons.push(Common.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit(),
                reportTitle: 'Product List',
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

        protected createSlickGrid() {
            var grid = super.createSlickGrid();

            // need to register this plugin for grouping or you'll have errors
            grid.registerPlugin(new Slick.Data.GroupItemMetadataProvider());

            this.view.setSummaryOptions({
                aggregators: [
                    new Slick.Aggregators.Sum('CutterM'),
                    new Slick.Aggregators.Sum('Perforation5'),
                    new Slick.Aggregators.Sum('Perforation8'),
                    new Slick.Aggregators.Sum('Perforation10'),
                    new Slick.Aggregators.Sum('Perforation12'),
                    new Slick.Aggregators.Sum('Perforation15'),
                    new Slick.Aggregators.Sum('Perforation20'),
                    new Slick.Aggregators.Sum('Perforation35'),
                    new Slick.Aggregators.Sum('RauterM'),
                    new Slick.Aggregators.Sum('FormatM'),
                    new Slick.Aggregators.Sum('FormatM2'),
                    new Slick.Aggregators.Sum('TotalOrder'),
                    new Slick.Aggregators.Sum('ClosedOrder'),
                    new Slick.Aggregators.Sum('OrderInTime'),
                    new Slick.Aggregators.Sum('Claims'),

                ]
            });

            return grid;
        }

    

        protected getSlickOptions() {
            var opt = super.getSlickOptions();
            opt.showFooterRow = true;
            return opt;
        }

        protected usePager() {
            return false;
        }


    }
}