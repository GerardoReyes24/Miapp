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
       
        validateEntity(row, id) {
           row.DesignTypeId = Q.toId(row.DesignTypeId);
             /*
            var sameDesignType = Q.tryFirst(this.view.getItems(), x => x.DesignTypeId === row.DesignTypeID);
            if (sameDesignType && this.id(sameDesignType) !== id) {
                Q.alert('Tipo de diseño existente!');
                return false;
            }
             */

            row.DesType = DesignTypeRow.getLookup().itemById[row.DesignTypeId].DesType;
   
            return true;
        }
    }
}