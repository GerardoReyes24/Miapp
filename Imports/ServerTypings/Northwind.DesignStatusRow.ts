namespace Miapp2.Northwind {
    export interface DesignStatusRow {
        ProjectID?: number;
        Blueprints?: boolean;
        PorposalFirst?: boolean;
        Measures?: boolean;
        Corrections?: boolean;
        PorposalFinal?: boolean;
    }

    export namespace DesignStatusRow {
        export const idProperty = 'ProjectID';
        export const localTextPrefix = 'Northwind.DesignStatus';

        export declare const enum Fields {
            ProjectID = "ProjectID",
            Blueprints = "Blueprints",
            PorposalFirst = "PorposalFirst",
            Measures = "Measures",
            Corrections = "Corrections",
            PorposalFinal = "PorposalFinal"
        }
    }
}
