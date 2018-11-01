namespace Miapp2.Northwind {
    export interface CustomerGrossSalesRow {
        ProyectorId?: number;
        ProyectorName?: string;
        NoCasaId?: number;
        NoCasaNumeroCasa?: string;
        GrossAmount?: number;
    }

    export namespace CustomerGrossSalesRow {
        export const nameProperty = 'ProyectorName';
        export const localTextPrefix = 'Northwind.CustomerGrossSales';

        export declare const enum Fields {
            ProyectorId = "ProyectorId",
            ProyectorName = "ProyectorName",
            NoCasaId = "NoCasaId",
            NoCasaNumeroCasa = "NoCasaNumeroCasa",
            GrossAmount = "GrossAmount"
        }
    }
}
