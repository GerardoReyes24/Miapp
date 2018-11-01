namespace Miapp2.Northwind {
    export interface RUbicacionRow {
        RUbicacionId?: number;
        RUbicacionN?: string;
        RUbicacionDesc?: string;
    }

    export namespace RUbicacionRow {
        export const idProperty = 'RUbicacionId';
        export const nameProperty = 'RUbicacionN';
        export const localTextPrefix = 'Northwind.RUbicacion';
        export const lookupKey = 'Northwind.RUbicacion';

        export function getLookup(): Q.Lookup<RUbicacionRow> {
            return Q.getLookup<RUbicacionRow>('Northwind.RUbicacion');
        }

        export declare const enum Fields {
            RUbicacionId = "RUbicacionId",
            RUbicacionN = "RUbicacionN",
            RUbicacionDesc = "RUbicacionDesc"
        }
    }
}
