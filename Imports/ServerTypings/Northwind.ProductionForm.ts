namespace Miapp2.Northwind {
    export interface ProductionForm {
        Date: Serenity.DateEditor;
        CutterM: Serenity.DecimalEditor;
        Perforation5: Serenity.IntegerEditor;
        Perforation8: Serenity.IntegerEditor;
        Perforation10: Serenity.IntegerEditor;
        Perforation12: Serenity.IntegerEditor;
        Perforation15: Serenity.IntegerEditor;
        Perforation20: Serenity.IntegerEditor;
        Perforation35: Serenity.IntegerEditor;
        RauterM: Serenity.IntegerEditor;
        FormatM: Serenity.IntegerEditor;
        TotalOrder: Serenity.IntegerEditor;
        ClosedOrder: Serenity.IntegerEditor;
        OrderInTime: Serenity.IntegerEditor;
        Claims: Serenity.IntegerEditor;
    }

    export class ProductionForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.Production';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductionForm.init)  {
                ProductionForm.init = true;

                var s = Serenity;
                var w0 = s.DateEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(ProductionForm, [
                    'Date', w0,
                    'CutterM', w1,
                    'Perforation5', w2,
                    'Perforation8', w2,
                    'Perforation10', w2,
                    'Perforation12', w2,
                    'Perforation15', w2,
                    'Perforation20', w2,
                    'Perforation35', w2,
                    'RauterM', w2,
                    'FormatM', w2,
                    'TotalOrder', w2,
                    'ClosedOrder', w2,
                    'OrderInTime', w2,
                    'Claims', w2
                ]);
            }
        }
    }
}
