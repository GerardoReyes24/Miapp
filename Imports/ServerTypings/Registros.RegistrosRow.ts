namespace Miapp2.Registros {
    export interface RegistrosRow {
        RegistroId?: number;
        Fecha?: string;
        ProductId?: string;
        Cantidad?: number;
        Movimiento?: TipoMovimiento;
        NoOrden?: string;
        ProyectorId?: number;
        TipoMuebleId?: number;
        NoCasaId?: number;
        ProductProductName?: string;
        ProductSupplierId?: number;
        ProductCategoryId?: number;
        ProductUnitPrice?: number;
        ProductUnitsInStock?: number;
        ProductDiscontinued?: boolean;
        ProductProductImage?: string;
        ProductProduct2Id?: string;
        ProyectorProyectorName?: string;
        ProyectorDescription?: string;
        TipoMuebleMuebleName?: string;
        TipoMuebleMuebleDescription?: string;
        NoCasaNumeroCasa?: string;
    }

    export namespace RegistrosRow {
        export const idProperty = 'RegistroId';
        export const nameProperty = 'ProductId';
        export const localTextPrefix = 'Registros.Registros';

        export declare const enum Fields {
            RegistroId = "RegistroId",
            Fecha = "Fecha",
            ProductId = "ProductId",
            Cantidad = "Cantidad",
            Movimiento = "Movimiento",
            NoOrden = "NoOrden",
            ProyectorId = "ProyectorId",
            TipoMuebleId = "TipoMuebleId",
            NoCasaId = "NoCasaId",
            ProductProductName = "ProductProductName",
            ProductSupplierId = "ProductSupplierId",
            ProductCategoryId = "ProductCategoryId",
            ProductUnitPrice = "ProductUnitPrice",
            ProductUnitsInStock = "ProductUnitsInStock",
            ProductDiscontinued = "ProductDiscontinued",
            ProductProductImage = "ProductProductImage",
            ProductProduct2Id = "ProductProduct2Id",
            ProyectorProyectorName = "ProyectorProyectorName",
            ProyectorDescription = "ProyectorDescription",
            TipoMuebleMuebleName = "TipoMuebleMuebleName",
            TipoMuebleMuebleDescription = "TipoMuebleMuebleDescription",
            NoCasaNumeroCasa = "NoCasaNumeroCasa"
        }
    }
}
