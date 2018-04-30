namespace Miapp2.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'Miapp2.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
