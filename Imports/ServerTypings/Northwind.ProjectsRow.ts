namespace Miapp2.Northwind {
    export interface ProjectsRow {
        ProjectId?: number;
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
    }

    export namespace ProjectsRow {
        export const idProperty = 'ProjectId';
        export const nameProperty = 'CustomerId';
        export const localTextPrefix = 'Northwind.Projects';

        export declare const enum Fields {
            ProjectId = "ProjectId",
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
            DetailList = "DetailList"
        }
    }
}
