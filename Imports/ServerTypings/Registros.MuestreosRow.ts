namespace Miapp2.Registros {
    export interface MuestreosRow {
        MuestreosId?: number;
        Fecha?: string;
        ProductId?: string;
        CantidadAMuestrear?: number;
        CantidadContada?: number;
        DesviacionEconomica?: number;
        ProductProductName?: string;
        ProductSupplierId?: number;
        ProductCategoryId?: number;
        ProductUnitPrice?: number;
        ProductUnitsInStock?: number;
        ProductDiscontinued?: boolean;
        ProductProductImage?: string;
        ProductProduct2Id?: string;
    }

    export namespace MuestreosRow {
        export const idProperty = 'MuestreosId';
        export const nameProperty = 'ProductId';
        export const localTextPrefix = 'Registros.Muestreos';
        export const lookupKey = 'Registros.Muestreos';

        export function getLookup(): Q.Lookup<MuestreosRow> {
            return Q.getLookup<MuestreosRow>('Registros.Muestreos');
        }

        export declare const enum Fields {
            MuestreosId = "MuestreosId",
            Fecha = "Fecha",
            ProductId = "ProductId",
            CantidadAMuestrear = "CantidadAMuestrear",
            CantidadContada = "CantidadContada",
            DesviacionEconomica = "DesviacionEconomica",
            ProductProductName = "ProductProductName",
            ProductSupplierId = "ProductSupplierId",
            ProductCategoryId = "ProductCategoryId",
            ProductUnitPrice = "ProductUnitPrice",
            ProductUnitsInStock = "ProductUnitsInStock",
            ProductDiscontinued = "ProductDiscontinued",
            ProductProductImage = "ProductProductImage",
            ProductProduct2Id = "ProductProduct2Id"
        }
    }
}
