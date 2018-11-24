namespace Miapp2.Northwind {
    export interface CustomerGrossSalesRow {
        ProyectorId?: number;
        ProyectorName?: string;
        NoCasaId?: number;
        NumeroCasa?: string;
        GrossAmount?: number;
        TipoMuebleId?: number;
        MuebleName?: string;
        RegistroId?: number;
        Cantidad?: number;
        ProductId?: string;
        ProductName?: string;
    }

    export namespace CustomerGrossSalesRow {
        export const nameProperty = 'ProyectorName';
        export const localTextPrefix = 'Northwind.CustomerGrossSales';

        export declare const enum Fields {
            ProyectorId = "ProyectorId",
            ProyectorName = "ProyectorName",
            NoCasaId = "NoCasaId",
            NumeroCasa = "NumeroCasa",
            GrossAmount = "GrossAmount",
            TipoMuebleId = "TipoMuebleId",
            MuebleName = "MuebleName",
            RegistroId = "RegistroId",
            Cantidad = "Cantidad",
            ProductId = "ProductId",
            ProductName = "ProductName"
        }
    }
}
