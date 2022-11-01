using System;
using System.Collections.Generic;

namespace FBDAL.Entities
{
    public partial class TblDictGroupType
    {
        public TblDictGroupType()
        {
            TblGroups = new HashSet<TblGroup>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TblGroup> TblGroups { get; set; }
    }
}
