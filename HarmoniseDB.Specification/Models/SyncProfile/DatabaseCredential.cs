namespace HarmoniseDB.Specification.Models.SyncProfile
{
    public class DatabaseCredential
    {
        public string ConnectionString
        {
            get
            {
                return string.Empty;
            }
        }

        public string SQLServerInstance { get; set; } = "localhost";

        public string InitialCatalog { get; set; } = "master";

        public bool IntegratedSecurity { get; set; } = true;

        public string UserId { get; set; }

        public string UserPassword { get; set; }
    }
}