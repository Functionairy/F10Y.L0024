using System;


namespace F10Y.L0024
{
    public class JsonDocumentOperator : IJsonDocumentOperator
    {
        #region Infrastructure

        public static IJsonDocumentOperator Instance { get; } = new JsonDocumentOperator();


        private JsonDocumentOperator()
        {
        }

        #endregion
    }
}
