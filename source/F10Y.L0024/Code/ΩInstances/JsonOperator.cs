using System;


namespace F10Y.L0024
{
    public class JsonOperator : IJsonOperator
    {
        #region Infrastructure

        public static IJsonOperator Instance { get; } = new JsonOperator();


        private JsonOperator()
        {
        }

        #endregion
    }
}
