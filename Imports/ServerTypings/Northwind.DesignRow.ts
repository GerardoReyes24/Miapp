namespace Miapp2.Northwind {
    export interface DesignRow {
        DesignId?: number;
        Date?: string;
        DesignTypeId?: number;
        DesignTime?: number;
        DesignInTime?: boolean;
        Aproved?: boolean;
        DesignTypeDesType?: string;
    }

    export namespace DesignRow {
        export const idProperty = 'DesignId';
        export const localTextPrefix = 'Northwind.Design';

        export declare const enum Fields {
            DesignId = "DesignId",
            Date = "Date",
            DesignTypeId = "DesignTypeId",
            DesignTime = "DesignTime",
            DesignInTime = "DesignInTime",
            Aproved = "Aproved",
            DesignTypeDesType = "DesignTypeDesType"
        }
    }
}
