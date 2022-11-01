using System;
using System.Collections.Generic;

namespace FBDAL.Entities
{
    public partial class TblDictFaqtype
    {
        public TblDictFaqtype()
        {
            TblWebFaqs = new HashSet<TblWebFaq>();
        }

        public int FaqtypeId { get; set; }
        public string FaqtypeDesc { get; set; } = null!;

        public virtual ICollection<TblWebFaq> TblWebFaqs { get; set; }
    }
}
