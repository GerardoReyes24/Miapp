namespace Miapp2.Northwind.Production {
    export interface ProductionListRequest extends Serenity.ListRequest {
        StartDate?: string;
        EndDate?: string;
    }
}
