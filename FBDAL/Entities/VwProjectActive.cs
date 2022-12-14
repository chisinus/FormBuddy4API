using System;
using System.Collections.Generic;

namespace FBDAL.Entities
{
    public partial class VwProjectActive
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = null!;
        public DateTime ProjectCreatedOn { get; set; }
        public int ProjectStatusId { get; set; }
        public string ProjectStatusDesc { get; set; } = null!;
        public int CompanyId { get; set; }
        public DateTime ProjectDeletedOn { get; set; }
    }
}
