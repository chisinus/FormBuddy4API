using System;
using System.Collections.Generic;

namespace FBDAL.Entities
{
    public partial class TblSysConfig
    {
        public int CurrentVersion { get; set; }
        public string ScriptFolder { get; set; } = null!;
        public string TechSupportEmailAddress { get; set; } = null!;
    }
}
