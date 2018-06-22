namespace Miapp2.Northwind {
    export interface MetodosRow {
        MetodId?: number;
        MetodName?: string;
        MetodPrice?: number;
    }

    export namespace MetodosRow {
        export const idProperty = 'MetodId';
        export const nameProperty = 'MetodName';
        export const localTextPrefix = 'Northwind.Metodos';

        export declare const enum Fields {
            MetodId = "MetodId",
            MetodName = "MetodName",
            MetodPrice = "MetodPrice"
        }
    }
}
