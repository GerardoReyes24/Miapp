namespace Miapp2.Registros {
    export interface RegistrosRow {
        RegistroId?: number;
        Fecha?: string;
        ProductId?: string;
        Cantidad?: number;
        Movimiento?: TipoMovimiento;
        DetailID?: number;
        DesignTypeId?: string;
        ProductProductName?: string;
        ProductSupplierId?: number;
        ProductCategoryId?: number;
        ProductUnitPrice?: number;
        ProductUnitsInStock?: number;
        ProductDiscontinued?: boolean;
        ProductProductImage?: string;
        ProjectID?: number;
        ProjectName?: string;
    }

    export namespace RegistrosRow {
        export const idProperty = 'RegistroId';
        export const nameProperty = 'ProductId';
        export const localTextPrefix = 'Registros.Registros';
        export const lookupKey = 'Registros.Registros';

        export function getLookup(): Q.Lookup<RegistrosRow> {
            return Q.getLookup<RegistrosRow>('Registros.Registros');
        }

        export declare const enum Fields {
            RegistroId = "RegistroId",
            Fecha = "Fecha",
            ProductId = "ProductId",
            Cantidad = "Cantidad",
            Movimiento = "Movimiento",
            DetailID = "DetailID",
            DesignTypeId = "DesignTypeId",
            ProductProductName = "ProductProductName",
            ProductSupplierId = "ProductSupplierId",
            ProductCategoryId = "ProductCategoryId",
            ProductUnitPrice = "ProductUnitPrice",
            ProductUnitsInStock = "ProductUnitsInStock",
            ProductDiscontinued = "ProductDiscontinued",
            ProductProductImage = "ProductProductImage",
            ProjectID = "ProjectID",
            ProjectName = "ProjectName"
        }
    }
}
