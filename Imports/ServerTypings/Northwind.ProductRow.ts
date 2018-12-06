namespace Miapp2.Northwind {
    export interface ProductRow {
        ProductID?: string;
        Product2ID?: string;
        ProductName?: string;
        ProductImage?: string;
        Discontinued?: boolean;
        SupplierID?: number;
        CategoryID?: number;
        UnitPrice?: number;
        UnitsInStock?: number;
        SupplierCompanyName?: string;
        SupplierContactName?: string;
        SupplierAddress?: string;
        CategoryName?: string;
        QuantityPerUnit?: string;
        CategoryDescription?: string;
        CategoryPicture?: number[];
    }

    export namespace ProductRow {
        export const idProperty = 'ProductID';
        export const nameProperty = 'ProductName';
        export const localTextPrefix = 'Northwind.Product';
        export const lookupKey = 'Some.Lookup';

        export function getLookup(): Q.Lookup<ProductRow> {
            return Q.getLookup<ProductRow>('Some.Lookup');
        }

        export declare const enum Fields {
            ProductID = "ProductID",
            Product2ID = "Product2ID",
            ProductName = "ProductName",
            ProductImage = "ProductImage",
            Discontinued = "Discontinued",
            SupplierID = "SupplierID",
            CategoryID = "CategoryID",
            UnitPrice = "UnitPrice",
            UnitsInStock = "UnitsInStock",
            SupplierCompanyName = "SupplierCompanyName",
            SupplierContactName = "SupplierContactName",
            SupplierAddress = "SupplierAddress",
            CategoryName = "CategoryName",
            QuantityPerUnit = "QuantityPerUnit",
            CategoryDescription = "CategoryDescription",
            CategoryPicture = "CategoryPicture"
        }
    }
}
