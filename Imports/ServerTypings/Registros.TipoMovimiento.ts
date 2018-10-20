namespace Miapp2.Registros {
    export enum TipoMovimiento {
        Entrada = 1,
        Salida = 2,
        Devolucion = 3
    }
    Serenity.Decorators.registerEnumType(TipoMovimiento, 'Miapp2.Registros.TipoMovimiento', 'Registros.TipoMOvimiento');
}
