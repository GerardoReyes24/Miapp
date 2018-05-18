namespace Miapp2.ImportFiles {
    export interface PruebaRow {
        Type1?: string;
        Type2?: number;
        Type3?: number;
    }

    export namespace PruebaRow {
        export const idProperty = 'Type1';
        export const nameProperty = 'Type1';
        export const localTextPrefix = 'ImportFiles.Prueba';

        export declare const enum Fields {
            Type1 = "Type1",
            Type2 = "Type2",
            Type3 = "Type3"
        }
    }
}
