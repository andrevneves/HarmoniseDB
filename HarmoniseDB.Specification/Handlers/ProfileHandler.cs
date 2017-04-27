using HarmoniseDB.Specification.Models.HandlerResponse;
using HarmoniseDB.Specification.Models.SyncProfile;

namespace HarmoniseDB.Specification.Handlers
{
    public class ProfileHandler
    {
        public SyncProfile Load(string specificationPath)
        {
            return null;
        }

        public SaveResponse Save()
        {
            return new SaveResponse { Result = true };
        }

        public RunResponse Run()
        {
            return new RunResponse { Result = true };
        }
    }
}