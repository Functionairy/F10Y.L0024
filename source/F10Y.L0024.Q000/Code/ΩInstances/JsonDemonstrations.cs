using System;


namespace F10Y.L0024.Q000
{
    public class JsonDemonstrations : IJsonDemonstrations
    {
        #region Infrastructure

        public static IJsonDemonstrations Instance { get; } = new JsonDemonstrations();


        private JsonDemonstrations()
        {
        }

        #endregion
    }
}
