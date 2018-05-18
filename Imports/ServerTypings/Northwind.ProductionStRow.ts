namespace Miapp2.Northwind {
    export interface ProductionStRow {
        DetailID?: number;
        Cutter?: ProdStatus;
        Cnc?: ProdStatus;
        Plating?: ProdStatus;
        Detailed?: ProdStatus;
        Armed?: ProdStatus;
        Packed?: ProdStatus;
        Installed?: ProdStatus;
    }

    export namespace ProductionStRow {
        export const idProperty = 'DetailID';
        export const localTextPrefix = 'Northwind.ProductionSt';

        export declare const enum Fields {
            DetailID = "DetailID",
            Cutter = "Cutter",
            Cnc = "Cnc",
            Plating = "Plating",
            Detailed = "Detailed",
            Armed = "Armed",
            Packed = "Packed",
            Installed = "Installed"
        }
    }
}
