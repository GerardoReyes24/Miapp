namespace Miapp2.Registros {
    export namespace RegistrosService {
        export const baseUrl = 'Registros/Registros';

        export declare function Create(request: Serenity.SaveRequest<RegistrosRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<RegistrosRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RegistrosRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RegistrosRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Registros/Registros/Create",
            Update = "Registros/Registros/Update",
            Retrieve = "Registros/Registros/Retrieve",
            List = "Registros/Registros/List"
        }

        [
            'Create', 
            'Update', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>RegistrosService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
