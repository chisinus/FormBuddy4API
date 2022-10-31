using System;
using System.Collections.Generic;

namespace FBDAL.Entities
{
    public partial class TblDictApplicationType
    {
        public int ApplicationTypeId { get; set; }
        public string ApplicationTypeDesc { get; set; } = null!;
    }
}
