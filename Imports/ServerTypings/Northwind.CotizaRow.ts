namespace Miapp2.Northwind {
    export interface CotizaRow {
        MetodId?: number;
        MetodName?: string;
        MetodPrice?: number;
    }

    export namespace CotizaRow {
        export const idProperty = 'MetodId';
        export const nameProperty = 'MetodName';
        export const localTextPrefix = 'Northwind.Cotiza';

        export declare const enum Fields {
            MetodId = "MetodId",
            MetodName = "MetodName",
            MetodPrice = "MetodPrice"
        }
    }
}
