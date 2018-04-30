
namespace Miapp2.Northwind {


    import fld = DesignRow.Fields;
    @Serenity.Decorators.registerClass()
    export class DesignGrid extends Serenity.EntityGrid<DesignRow, any> {
        protected getColumnsKey() { return 'Northwind.Design'; }
        protected getDialogType() { return <any>DesignDialog; }
        protected getIdProperty() { return DesignRow.idProperty; }
        protected getLocalTextPrefix() { return DesignRow.localTextPrefix; }
        protected getService() { return DesignService.baseUrl; }

  

        constructor(container: JQuery) {
            super(container);          
        }

       

        public getColumns(): Slick.Column[] {
            var columns = super.getColumns();
                 

            Q.first(columns, x => x.field == fld.DesignTime).cssClass += " col-unit-price";
         
        
       
            return columns;
        }

        public getItemCssClass(item: DesignRow, index: number): string {
            let klass: string = "";

            if (item.Aproved == true)
                klass += "Aproved";
            else
                klass += "out-of-stock";
      
          

            return Q.trimToNull(klass);
        }

        

         

  
    }
}