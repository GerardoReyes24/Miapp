
namespace Miapp2.ImportFiles.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("ImportFiles.Pieza")]
    [BasedOnRow(typeof(Entities.PiezaRow), CheckNames = true)]
    public class PiezaForm
    {
        public String Pieza { get; set; }
        public Decimal GrosTab { get; set; }
        public String Enchapado { get; set; }
        public Decimal MtsEnchapado { get; set; }
        public Decimal MtsCorte { get; set; }
    }
}