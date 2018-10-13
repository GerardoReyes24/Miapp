
namespace Miapp2.Registros.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Registros.Muestreos")]
    [BasedOnRow(typeof(Entities.MuestreosRow), CheckNames = true)]
    public class MuestreosForm
    {
        [DisplayName ("Fecha de muestreo")]
        public DateTime Fecha { get; set; }
        [DisplayName ("Material")]
        public String ProductId { get; set; }
        [DisplayName("Cantidad  contada")]
        public Decimal CantidadAMuestrear { get; set; }
   
    }
}