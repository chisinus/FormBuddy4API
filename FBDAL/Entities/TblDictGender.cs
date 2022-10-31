using System;
using System.Collections.Generic;

namespace FBDAL.Entities
{
    public partial class TblDictGender
    {
        public TblDictGender()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
