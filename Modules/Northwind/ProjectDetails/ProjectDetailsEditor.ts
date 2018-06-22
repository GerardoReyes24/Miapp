/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Miapp2.Northwind {

    @Serenity.Decorators.registerClass()
    export class ProjectDetailsEditor extends Common.GridEditorBase<ProjectDetailsRow> {
        protected getColumnsKey() { return 'Northwind.ProjectDetails'; }
        protected getDialogType() { return ProjectDetailsDialog; }
        protected getLocalTextPrefix() { return ProjectDetailsRow.localTextPrefix; }
        protected getService() { return ProjectDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
       
        
    }
}