using System;


namespace F10Y.L0024
{
    public static class Instances
    {
        public static L0000.IFileStreamOperator FileStreamOperator => L0000.FileStreamOperator.Instance;
        public static L0000.IHttpClientOperator HttpClientOperator => L0000.HttpClientOperator.Instance;
        public static IJsonDocumentOperator JsonDocumentOperator => L0024.JsonDocumentOperator.Instance;
        public static IJsonElementOperator JsonElementOperator => L0024.JsonElementOperator.Instance;
        public static L0000.ITypeOperator TypeOperator => L0000.TypeOperator.Instance;
    }
}