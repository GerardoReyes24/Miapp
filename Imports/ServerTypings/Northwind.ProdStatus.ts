namespace Miapp2.Northwind {
    export enum ProdStatus {
        Empezado = 1,
        EnProceso = 2,
        Terminado = 3
    }
    Serenity.Decorators.registerEnumType(ProdStatus, 'Miapp2.Northwind.ProdStatus', 'ProductionSt.Status');
}
