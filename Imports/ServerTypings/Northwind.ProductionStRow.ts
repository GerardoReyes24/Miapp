namespace Miapp2.Northwind {
    export interface ProductionStRow {
        ProductionStId?: number;
        DetailId?: number;
        Cutter?: ProdStatus;
        Cnc?: ProdStatus;
        Plating?: ProdStatus;
        Armed?: ProdStatus;
        Packed?: ProdStatus;
    }

    export namespace ProductionStRow {
        export const idProperty = 'ProductionStId';
        export const localTextPrefix = 'Northwind.ProductionSt';

        export declare const enum Fields {
            ProductionStId = "ProductionStId",
            DetailId = "DetailId",
            Cutter = "Cutter",
            Cnc = "Cnc",
            Plating = "Plating",
            Armed = "Armed",
            Packed = "Packed"
        }
    }
}
