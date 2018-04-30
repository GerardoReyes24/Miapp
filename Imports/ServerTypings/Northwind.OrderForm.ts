namespace Miapp2.Northwind {
    export interface OrderForm {
        CustomerID: CustomerEditor;
        OrderDate: Serenity.DateEditor;
        RequiredDate: Serenity.DateEditor;
        EmployeeID: Serenity.LookupEditor;
        DetailList: OrderDetailsEditor;
    }

    export class OrderForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.Order';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderForm.init)  {
                OrderForm.init = true;

                var s = Serenity;
                var w0 = CustomerEditor;
                var w1 = s.DateEditor;
                var w2 = s.LookupEditor;
                var w3 = OrderDetailsEditor;

                Q.initFormType(OrderForm, [
                    'CustomerID', w0,
                    'OrderDate', w1,
                    'RequiredDate', w1,
                    'EmployeeID', w2,
                    'DetailList', w3
                ]);
            }
        }
    }
}
