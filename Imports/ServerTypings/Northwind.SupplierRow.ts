namespace Miapp2.Northwind {
    export interface SupplierRow {
        SupplierID?: number;
        CompanyName?: string;
        ContactName?: string;
        Address?: string;
    }

    export namespace SupplierRow {
        export const idProperty = 'SupplierID';
        export const nameProperty = 'CompanyName';
        export const localTextPrefix = 'Northwind.Supplier';
        export const lookupKey = 'Northwind.Supplier';

        export function getLookup(): Q.Lookup<SupplierRow> {
            return Q.getLookup<SupplierRow>('Northwind.Supplier');
        }

        export declare const enum Fields {
            SupplierID = "SupplierID",
            CompanyName = "CompanyName",
            ContactName = "ContactName",
            Address = "Address"
        }
    }
}
