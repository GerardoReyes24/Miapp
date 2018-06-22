namespace Miapp2.Northwind {
    export interface ProductLangRow {
        Id?: number;
        ProductId?: string;
        LanguageId?: number;
        ProductName?: string;
    }

    export namespace ProductLangRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ProductName';
        export const localTextPrefix = 'Northwind.ProductLang';

        export declare const enum Fields {
            Id = "Id",
            ProductId = "ProductId",
            LanguageId = "LanguageId",
            ProductName = "ProductName"
        }
    }
}
