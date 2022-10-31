using System;
using System.Collections.Generic;

namespace FBDAL.Entities
{
    public partial class TblUserLocation
    {
        public int UserLocationId { get; set; }
        public int UserId { get; set; }
        public int CurrentGroupId { get; set; }
        public int CurrentProjectId { get; set; }

        public virtual TblUser User { get; set; } = null!;
    }
}
