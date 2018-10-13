namespace Miapp2.Northwind {
    export interface ProjectDetailsRow {
        DetailID?: number;
        ProjectID?: number;
        DesignTypeId?: string;
        Width?: number;
        Deep?: number;
        High?: number;
        Observaciones?: string;
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
        export const nameProperty = 'DesignTypeId';
        export const localTextPrefix = 'Northwind.ProjectDetails';
        export const lookupKey = 'Somes.Lookup';

        export function getLookup(): Q.Lookup<ProjectDetailsRow> {
            return Q.getLookup<ProjectDetailsRow>('Somes.Lookup');
        }

        export declare const enum Fields {
            DetailID = "DetailID",
            ProjectID = "ProjectID",
            DesignTypeId = "DesignTypeId",
            Width = "Width",
            Deep = "Deep",
            High = "High",
            Observaciones = "Observaciones",
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
