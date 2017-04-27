using System;

namespace HarmoniseDB.Specification.Models
{
    public class SyncProfile
    {
        public string SyncProfileName { get; set; }

        public DateTime DateUpdated { get; set; }

        public DatabaseCredential SourceDatabase { get; set; }

        public DatabaseCredential TargetDatabase { get; set; }
    }
}