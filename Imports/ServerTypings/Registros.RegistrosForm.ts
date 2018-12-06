namespace Miapp2.Registros {
    export interface RegistrosForm {
        Fecha: Serenity.DateEditor;
        ProductId: Northwind.ProductEditor;
        Cantidad: Serenity.DecimalEditor;
        Movimiento: Serenity.EnumEditor;
        NoOrden: Serenity.StringEditor;
        ProyectorId: Serenity.LookupEditor;
        NoCasaId: Serenity.LookupEditor;
        RUbicacionId: Serenity.LookupEditor;
        TipoMuebleId: Serenity.LookupEditor;
    }

    export class RegistrosForm extends Serenity.PrefixedContext {
        static formKey = 'Registros.Registros';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RegistrosForm.init)  {
                RegistrosForm.init = true;

                var s = Serenity;
                var w0 = s.DateEditor;
                var w1 = Northwind.ProductEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.EnumEditor;
                var w4 = s.StringEditor;
                var w5 = s.LookupEditor;

                Q.initFormType(RegistrosForm, [
                    'Fecha', w0,
                    'ProductId', w1,
                    'Cantidad', w2,
                    'Movimiento', w3,
                    'NoOrden', w4,
                    'ProyectorId', w5,
                    'NoCasaId', w5,
                    'RUbicacionId', w5,
                    'TipoMuebleId', w5
                ]);
            }
        }
    }
}
