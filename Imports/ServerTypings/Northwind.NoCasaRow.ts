namespace Miapp2.Northwind {
    export interface NoCasaRow {
        NoCasaId?: number;
        NumeroCasa?: string;
    }

    export namespace NoCasaRow {
        export const idProperty = 'NoCasaId';
        export const nameProperty = 'NumeroCasa';
        export const localTextPrefix = 'Northwind.NoCasa';
        export const lookupKey = 'Northwind.NoCasa';

        export function getLookup(): Q.Lookup<NoCasaRow> {
            return Q.getLookup<NoCasaRow>('Northwind.NoCasa');
        }

        export declare const enum Fields {
            NoCasaId = "NoCasaId",
            NumeroCasa = "NumeroCasa"
        }
    }
}
