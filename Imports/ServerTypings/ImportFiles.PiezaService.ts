namespace Miapp2.ImportFiles {
    export namespace PiezaService {
        export const baseUrl = 'ImportFiles/Pieza';

        export declare function Create(request: Serenity.SaveRequest<PiezaRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<PiezaRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PiezaRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PiezaRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function resultt(request: Serenity.ServiceRequest, onSuccess?: (response: System.String) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "ImportFiles/Pieza/Create",
            Update = "ImportFiles/Pieza/Update",
            Delete = "ImportFiles/Pieza/Delete",
            Retrieve = "ImportFiles/Pieza/Retrieve",
            List = "ImportFiles/Pieza/List",
            resultt = "ImportFiles/Pieza/resultt",
            ExcelImport = "ImportFiles/Pieza/ExcelImport"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'resultt', 
            'ExcelImport'
        ].forEach(x => {
            (<any>PiezaService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
