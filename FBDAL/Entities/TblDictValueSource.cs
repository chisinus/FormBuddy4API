using System;
using System.Collections.Generic;

namespace FBDAL.Entities
{
    public partial class TblDictValueSource
    {
        public TblDictValueSource()
        {
            TblProjectControls = new HashSet<TblProjectControl>();
        }

        public int ValueSourceId { get; set; }
        public string ValueSourceDesc { get; set; } = null!;

        public virtual ICollection<TblProjectControl> TblProjectControls { get; set; }
    }
}
