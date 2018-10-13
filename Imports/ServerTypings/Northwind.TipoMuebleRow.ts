namespace Miapp2.Northwind {
    export interface TipoMuebleRow {
        TipoMuebleId?: number;
        MuebleName?: string;
        MuebleDescription?: string;
    }

    export namespace TipoMuebleRow {
        export const idProperty = 'TipoMuebleId';
        export const nameProperty = 'MuebleName';
        export const localTextPrefix = 'Northwind.TipoMueble';
        export const lookupKey = 'Northwind.TipoMueble';

        export function getLookup(): Q.Lookup<TipoMuebleRow> {
            return Q.getLookup<TipoMuebleRow>('Northwind.TipoMueble');
        }

        export declare const enum Fields {
            TipoMuebleId = "TipoMuebleId",
            MuebleName = "MuebleName",
            MuebleDescription = "MuebleDescription"
        }
    }
}
