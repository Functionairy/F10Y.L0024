using System;
using System.Text.Json;

using F10Y.T0002;


namespace F10Y.L0024
{
    /// <inheritdoc cref="Documentation.SeeAlso_F10Y_L0060"/>
    [FunctionsMarker]
    public partial interface IJsonElementOperator
    {
        public JsonElement Clone(JsonElement jElement)
        {
            var output = jElement.Clone();
            return output;
        }

        public T Deserialize<T>(JsonElement jsonElement)
        {
            var output = jsonElement.Deserialize<T>();
            return output;
        }

        public JsonElement Get_Property(
            JsonElement element,
            string propertyName)
        {
            var output = element.GetProperty(propertyName);
            return output;
        }

        public string Get_String(JsonElement element)
        {
            var output = element.GetString();
            return output;
        }

        public JsonElement Serialize_AsImplementationType<T>(T value)
        {
            var implementationType = Instances.TypeOperator.Get_Type_ImplementationType(value);

            var output = JsonSerializer.SerializeToElement(
                value,
                implementationType);

            return output;
        }

        public JsonElement Serialize_AsDeclaredType<T>(T value)
        {
            // The type used by the JSON serializer is the declared type of the value.
            var output = JsonSerializer.SerializeToElement(value);
            return output;
        }

        /// <summary>
        /// Chooses <see cref="Serialize_AsImplementationType{T}(T)"/> as the default.
        /// </summary>
        public JsonElement Serialize<T>(T value)
            => this.Serialize_AsImplementationType(value);
    }
}
