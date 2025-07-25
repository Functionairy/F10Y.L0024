using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using F10Y.T0002;


namespace F10Y.L0024
{
    /// <summary>
    /// System.Text.Json NuGet package-based JSON operator library. (For pre- .NET 6.0 libraries starting with .NET Standard 2.1.)
    /// </summary>
    /// <inheritdoc cref="Documentation.SeeAlso_F10Y_L0060"/>
    [FunctionsMarker]
    public partial interface IJsonOperator
    {
        public T Deserialize_FromText<T>(string jsonText)
        {
            var output = JsonSerializer.Deserialize<T>(jsonText);
            return output;
        }

        public T Get_Value<T>(JsonValue value)
            => value.GetValue<T>();

        public string Get_Value(JsonValue value)
            => this.Get_Value<string>(value);

        public JsonNode Get_Child(
            JsonNode node,
            string childName)
        {
            var output = node[childName];
            return output;
        }

        public T Get_Child_Value<T>(
            JsonNode node,
            string childName)
        {
            var value = this.Get_Child_AsValue(
                node,
                childName);

            var output = this.Get_Value<T>(value);
            return output;
        }

        public string Get_Child_Value(
            JsonNode node,
            string childName)
            => this.Get_Child_Value<string>(
                node,
                childName);

        public JsonValue Get_Child_AsValue(
            JsonNode node,
            string childname)
            => this.Get_Child(
                node,
                childname)
                .AsValue();

        public JsonElement Get_Property(
            JsonElement element,
            string propertyName)
            => Instances.JsonElementOperator.Get_Property(
                element,
                propertyName);

        public async Task<JsonElement> Get_Response(
            string url,
            bool ensureSuccessStatusCode = IValues.EnsureSuccessStatusCode_Default_Constant)
        {
            var json = await Instances.HttpClientOperator.Get_ReponseContent_AsString(
                url,
                ensureSuccessStatusCode);

            var output = Instances.JsonDocumentOperator.Deserialize_Text_AsJsonElement(json);
            return output;
        }

        public string Get_String(JsonElement element)
            => Instances.JsonElementOperator.Get_String(element);
    }
}
