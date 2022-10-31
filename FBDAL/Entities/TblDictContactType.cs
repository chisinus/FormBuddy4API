using System;
using System.Collections.Generic;

namespace FBDAL.Entities
{
    public partial class TblDictContactType
    {
        public TblDictContactType()
        {
            TblWebContacts = new HashSet<TblWebContact>();
        }

        public int ContactTypeId { get; set; }
        public string ContactTypeDesc { get; set; } = null!;

        public virtual ICollection<TblWebContact> TblWebContacts { get; set; }
    }
}
