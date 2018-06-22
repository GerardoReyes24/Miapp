
namespace Miapp2.ImportFiles.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("ImportFiles.Pieza")]
    [BasedOnRow(typeof(Entities.PiezaRow), CheckNames = true)]
    public class PiezaColumns
    {
      

      
        public String Pieza { get; set; }
        [Width(120), AlignCenter]
        public Decimal GrosTab { get; set; }
        [Width(180) ]
        public String Enchapado { get; set; }
        [Width(150)]
        public Decimal MtsEnchapado { get; set; }
        [Width(150)]
        public Decimal MtsCorte { get; set; }
    }
}