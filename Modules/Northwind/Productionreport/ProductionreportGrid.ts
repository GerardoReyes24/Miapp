namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class ProductionreportGrid extends Serenity.EntityGrid<Northwind.ProductionreportRow, any> {

        protected getColumnsKey() { return "Northwind.Productionreport"; }
        protected getIdProperty() { return "__id"; }
     /*   protected getNameProperty() { return Northwind.ProductionreportRow.nameProperty; } */
        protected getLocalTextPrefix() { return Northwind.ProductionreportRow.localTextPrefix; }
    /*    protected getService() { return ProductionreportService.baseUrl; }
    */
        private nextId = 1;

        constructor(container: JQuery) {
            super(container);
        }

      
      7/*

        protected getButtons() {
            var buttons = [];

            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: ProductionreportService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: true
            }));

            buttons.push(Common.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit()
            }));

            return buttons;
        }

*/
        protected createSlickGrid() {
            var grid = super.createSlickGrid();

     
            grid.registerPlugin(new Slick.Data.GroupItemMetadataProvider());

            this.view.setSummaryOptions({
                aggregators: [
                    new Slick.Aggregators.Sum('CutterM')
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

     /*   protected getQuickFilters() {
            var filters = super.getQuickFilters();

        
            var orderDate = this.dateRangeQuickFilter('Date', 'Order Date');

            orderDate.handler = args => {
                
          
                var start = args.widget.value;

           
                var end = args.widget.element.nextAll('.s-DateEditor')
                    .getWidget(Serenity.DateEditor).value;

                (args.request as ProductionreportListRequest).StartDate = start;
                (args.request as ProductionreportListRequest).EndDate = end;

            
                args.active = !Q.isEmptyOrNull(start) || !Q.isEmptyOrNull(end);
            };

            filters.push(orderDate);

            return filters;
        } */
    }
}