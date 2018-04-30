namespace Miapp2.Northwind {
    export interface PriorityRow {
        PriorityId?: number;
        PriorityDescription?: string;
    }

    export namespace PriorityRow {
        export const idProperty = 'PriorityId';
        export const nameProperty = 'PriorityDescription';
        export const localTextPrefix = 'Northwind.Priority';
        export const lookupKey = 'Northwind.Priority';

        export function getLookup(): Q.Lookup<PriorityRow> {
            return Q.getLookup<PriorityRow>('Northwind.Priority');
        }

        export declare const enum Fields {
            PriorityId = "PriorityId",
            PriorityDescription = "PriorityDescription"
        }
    }
}
