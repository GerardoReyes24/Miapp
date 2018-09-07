
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
        [DisplayName("Material")]
        public String ProductId { get; set; }
        public Decimal Cantidad { get; set; }
        public TipoMovimiento Movimiento { get; set; }
        [DisplayName("No de Orden")]
        public String NoOrder { get; set; }

        [DisplayName("Muble")]
        public Int32 DetailID { get; set; }

        [DisplayName("Proyecto")]
        public Int32 ProjectID { get; set; }
    }
}