using System;


namespace F10Y.L0024
{
    public class JsonSerializerOptionsSet : IJsonSerializerOptionsSet
    {
        #region Infrastructure

        public static IJsonSerializerOptionsSet Instance { get; } = new JsonSerializerOptionsSet();


        private JsonSerializerOptionsSet()
        {
        }

        #endregion
    }
}
