namespace Miapp2.Northwind {
    export interface CustomerGrossSalesRow {
        ProyectorId?: number;
        ProyectorName?: string;
        NoCasaId?: number;
        NumeroCasa?: string;
        GrossAmount?: number;
    }

    export namespace CustomerGrossSalesRow {
        export const nameProperty = 'ProyectorName';
        export const localTextPrefix = 'Northwind.CustomerGrossSales';

        export declare const enum Fields {
            ProyectorId = "ProyectorId",
            ProyectorName = "ProyectorName",
            NoCasaId = "NoCasaId",
            NumeroCasa = "NumeroCasa",
            GrossAmount = "GrossAmount"
        }
    }
}
