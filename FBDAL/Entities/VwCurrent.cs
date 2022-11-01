using System;
using System.Collections.Generic;

namespace FBDAL.Entities
{
    public partial class VwCurrent
    {
        public int CompanyId { get; set; }
        public int ProjectId { get; set; }
        public int CurrentUserId { get; set; }
        public int GroupId { get; set; }
        public string Wpid { get; set; } = null!;
    }
}
