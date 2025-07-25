using System;


namespace F10Y.L0024
{
    public class JsonElementOperator : IJsonElementOperator
    {
        #region Infrastructure

        public static IJsonElementOperator Instance { get; } = new JsonElementOperator();


        private JsonElementOperator()
        {
        }

        #endregion
    }
}
