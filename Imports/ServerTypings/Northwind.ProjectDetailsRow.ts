namespace Miapp2.Northwind {
    export interface ProjectDetailsRow {
        DetailID?: number;
        ProjectID?: number;
        DesignTypeId?: number;
        Width?: number;
        Deep?: number;
        High?: number;
        Observaciones?: string;
        DesType?: string;
        ProjectCustomerId?: string;
        ProjectProjectName?: string;
        ProjectDescription?: string;
        ProjectRequiredDate?: string;
        ProjectPriorityId?: number;
        ProjectAproved?: boolean;
        Cutter?: ProdStatus;
        Cnc?: ProdStatus;
        Plating?: ProdStatus;
        Detailed?: ProdStatus;
        Armed?: ProdStatus;
        Packed?: ProdStatus;
        Installed?: ProdStatus;
    }

    export namespace ProjectDetailsRow {
        export const idProperty = 'DetailID';
        export const nameProperty = 'DesType';
        export const localTextPrefix = 'Northwind.ProjectDetails';

        export declare const enum Fields {
            DetailID = "DetailID",
            ProjectID = "ProjectID",
            DesignTypeId = "DesignTypeId",
            Width = "Width",
            Deep = "Deep",
            High = "High",
            Observaciones = "Observaciones",
            DesType = "DesType",
            ProjectCustomerId = "ProjectCustomerId",
            ProjectProjectName = "ProjectProjectName",
            ProjectDescription = "ProjectDescription",
            ProjectRequiredDate = "ProjectRequiredDate",
            ProjectPriorityId = "ProjectPriorityId",
            ProjectAproved = "ProjectAproved",
            Cutter = "Cutter",
            Cnc = "Cnc",
            Plating = "Plating",
            Detailed = "Detailed",
            Armed = "Armed",
            Packed = "Packed",
            Installed = "Installed"
        }
    }
}
