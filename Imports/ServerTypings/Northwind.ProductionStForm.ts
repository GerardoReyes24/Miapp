namespace Miapp2.Northwind {
    export interface ProductionStForm {
        DetailId: Serenity.IntegerEditor;
        Cutter: Serenity.EnumEditor;
        Cnc: Serenity.EnumEditor;
        Plating: Serenity.EnumEditor;
        Armed: Serenity.EnumEditor;
        Packed: Serenity.EnumEditor;
    }

    export class ProductionStForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.ProductionSt';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductionStForm.init)  {
                ProductionStForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.EnumEditor;

                Q.initFormType(ProductionStForm, [
                    'DetailId', w0,
                    'Cutter', w1,
                    'Cnc', w1,
                    'Plating', w1,
                    'Armed', w1,
                    'Packed', w1
                ]);
            }
        }
    }
}
