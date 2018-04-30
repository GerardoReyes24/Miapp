namespace Miapp2.Northwind {
    export namespace ProjectDetailsService {
        export const baseUrl = 'Northwind/ProjectDetails';

        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ProjectDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ProjectDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Retrieve = "Northwind/ProjectDetails/Retrieve",
            List = "Northwind/ProjectDetails/List"
        }

        [
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ProjectDetailsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
