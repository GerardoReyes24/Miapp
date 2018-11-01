
namespace Miapp2.Registros.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Miapp2.Registros.Endpoints;

    [FormScript("Registros.Registros")]
    [BasedOnRow(typeof(Entities.RegistrosRow), CheckNames = true)]
    public class RegistrosForm
    {
        public DateTime Fecha { get; set; }
        public String ProductId { get; set; }
        public Decimal Cantidad { get; set; }
        public TipoMovimiento Movimiento { get; set; }
        public String NoOrden { get; set; }
        public Int32 ProyectorId { get; set; }
        public Int32 NoCasaId { get; set; }
        public Int32 RUbicacionId { get; set; }
        public Int32 TipoMuebleId { get; set; }
       
    }
}