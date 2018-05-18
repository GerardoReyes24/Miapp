namespace Miapp2.BasicSamples {
    export namespace ProductionreportService {
        export const baseUrl = 'Northwind/Productionreport';

        export declare function List(request: ProductionreportListRequest, onSuccess?: (response: Serenity.ListResponse<Northwind.ProductionreportRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            List = "Northwind/Productionreport/List"
        }

        [
            'List'
        ].forEach(x => {
            (<any>ProductionreportService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
