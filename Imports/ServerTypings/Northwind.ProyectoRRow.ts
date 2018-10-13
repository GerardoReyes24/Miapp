namespace Miapp2.Northwind {
    export interface ProyectoRRow {
        ProyectorId?: number;
        ProyectorName?: string;
        Description?: string;
    }

    export namespace ProyectoRRow {
        export const idProperty = 'ProyectorId';
        export const nameProperty = 'ProyectorName';
        export const localTextPrefix = 'Northwind.ProyectoR';
        export const lookupKey = 'Northwind.ProyectoR';

        export function getLookup(): Q.Lookup<ProyectoRRow> {
            return Q.getLookup<ProyectoRRow>('Northwind.ProyectoR');
        }

        export declare const enum Fields {
            ProyectorId = "ProyectorId",
            ProyectorName = "ProyectorName",
            Description = "Description"
        }
    }
}
