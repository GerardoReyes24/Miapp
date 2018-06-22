namespace Miapp2.Northwind {
    export interface MisdatosRow {
        Campo1?: string;
        Campo2?: number;
        Campo3?: number;
    }

    export namespace MisdatosRow {
        export const idProperty = 'Campo1';
        export const nameProperty = 'Campo1';
        export const localTextPrefix = 'Northwind.Misdatos';

        export declare const enum Fields {
            Campo1 = "Campo1",
            Campo2 = "Campo2",
            Campo3 = "Campo3"
        }
    }
}
