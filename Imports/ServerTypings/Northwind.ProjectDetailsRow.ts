namespace Miapp2.Northwind {
    export interface ProjectDetailsRow {
        DetailId?: number;
        ProjectId?: number;
        DesignTypeId?: number;
        Width?: number;
        Deep?: number;
        High?: number;
        Observaciones?: string;
        DesignType?: string;
        ProjectCustomerId?: string;
        ProjectProjectName?: string;
        ProjectDescription?: string;
        ProjectRequiredDate?: string;
        ProjectPriorityId?: number;
        ProjectAproved?: boolean;
    }

    export namespace ProjectDetailsRow {
        export const idProperty = 'DetailId';
        export const localTextPrefix = 'Northwind.ProjectDetails';

        export declare const enum Fields {
            DetailId = "DetailId",
            ProjectId = "ProjectId",
            DesignTypeId = "DesignTypeId",
            Width = "Width",
            Deep = "Deep",
            High = "High",
            Observaciones = "Observaciones",
            DesignType = "DesignType",
            ProjectCustomerId = "ProjectCustomerId",
            ProjectProjectName = "ProjectProjectName",
            ProjectDescription = "ProjectDescription",
            ProjectRequiredDate = "ProjectRequiredDate",
            ProjectPriorityId = "ProjectPriorityId",
            ProjectAproved = "ProjectAproved"
        }
    }
}
