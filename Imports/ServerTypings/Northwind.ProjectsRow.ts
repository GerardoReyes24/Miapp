namespace Miapp2.Northwind {
    export interface ProjectsRow {
        ProjectID?: number;
        CustomerId?: string;
        ProjectName?: string;
        Description?: string;
        RequiredDate?: string;
        PriorityId?: number;
        Aproved?: boolean;
        CustomerCompanyName?: string;
        CustomerContactName?: string;
        CustomerContactTitle?: string;
        CustomerAddress?: string;
        CustomerCity?: string;
        CustomerRegion?: string;
        CustomerPostalCode?: string;
        CustomerCountry?: string;
        CustomerPhone?: string;
        CustomerFax?: string;
        CustomerId1?: number;
        PriorityPriorityDescription?: string;
        DetailList?: ProjectDetailsRow[];
        Blueprints?: boolean;
        PorposalFirst?: boolean;
        Measures?: boolean;
        Corrections?: boolean;
        PorposalFinal?: boolean;
    }

    export namespace ProjectsRow {
        export const idProperty = 'ProjectID';
        export const nameProperty = 'ProjectName';
        export const localTextPrefix = 'Northwind.Projects';
        export const lookupKey = 'Somee.Lookup';

        export function getLookup(): Q.Lookup<ProjectsRow> {
            return Q.getLookup<ProjectsRow>('Somee.Lookup');
        }

        export declare const enum Fields {
            ProjectID = "ProjectID",
            CustomerId = "CustomerId",
            ProjectName = "ProjectName",
            Description = "Description",
            RequiredDate = "RequiredDate",
            PriorityId = "PriorityId",
            Aproved = "Aproved",
            CustomerCompanyName = "CustomerCompanyName",
            CustomerContactName = "CustomerContactName",
            CustomerContactTitle = "CustomerContactTitle",
            CustomerAddress = "CustomerAddress",
            CustomerCity = "CustomerCity",
            CustomerRegion = "CustomerRegion",
            CustomerPostalCode = "CustomerPostalCode",
            CustomerCountry = "CustomerCountry",
            CustomerPhone = "CustomerPhone",
            CustomerFax = "CustomerFax",
            CustomerId1 = "CustomerId1",
            PriorityPriorityDescription = "PriorityPriorityDescription",
            DetailList = "DetailList",
            Blueprints = "Blueprints",
            PorposalFirst = "PorposalFirst",
            Measures = "Measures",
            Corrections = "Corrections",
            PorposalFinal = "PorposalFinal"
        }
    }
}
