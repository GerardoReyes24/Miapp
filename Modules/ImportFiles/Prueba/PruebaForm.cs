
namespace Miapp2.ImportFiles.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("ImportFiles.Prueba")]
    [BasedOnRow(typeof(Entities.PruebaRow), CheckNames = true)]
    public class PruebaForm
    {

        public String Type1 { get; set; }
        public Int32 Type2 { get; set; }
        public Decimal Type3 { get; set; }
    }
}