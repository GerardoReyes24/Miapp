namespace Miapp2.Northwind {
    export interface ProductionRow {
        ProductionId?: number;
        Date?: string;
        CutterM?: number;
        Perforation5?: number;
        Perforation8?: number;
        Perforation10?: number;
        Perforation12?: number;
        Perforation15?: number;
        Perforation20?: number;
        Perforation35?: number;
        RauterM?: number;
        FormatM?: number;
        FormatM2?: number;
        TotalOrder?: number;
        ClosedOrder?: number;
        OrderInTime?: number;
        Claims?: number;
    }

    export namespace ProductionRow {
        export const idProperty = 'ProductionId';
        export const localTextPrefix = 'Northwind.Production';

        export declare const enum Fields {
            ProductionId = "ProductionId",
            Date = "Date",
            CutterM = "CutterM",
            Perforation5 = "Perforation5",
            Perforation8 = "Perforation8",
            Perforation10 = "Perforation10",
            Perforation12 = "Perforation12",
            Perforation15 = "Perforation15",
            Perforation20 = "Perforation20",
            Perforation35 = "Perforation35",
            RauterM = "RauterM",
            FormatM = "FormatM",
            FormatM2 = "FormatM2",
            TotalOrder = "TotalOrder",
            ClosedOrder = "ClosedOrder",
            OrderInTime = "OrderInTime",
            Claims = "Claims"
        }
    }
}
