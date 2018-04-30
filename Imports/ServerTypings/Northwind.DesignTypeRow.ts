namespace Miapp2.Northwind {
    export interface DesignTypeRow {
        DesignTypeId?: number;
        DesType?: string;
    }

    export namespace DesignTypeRow {
        export const idProperty = 'DesignTypeId';
        export const nameProperty = 'DesType';
        export const localTextPrefix = 'Northwind.DesignType';
        export const lookupKey = 'Northwind.DesignType';

        export function getLookup(): Q.Lookup<DesignTypeRow> {
            return Q.getLookup<DesignTypeRow>('Northwind.DesignType');
        }

        export declare const enum Fields {
            DesignTypeId = "DesignTypeId",
            DesType = "DesType"
        }
    }
}
