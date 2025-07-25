using System;
using System.Text.Json;

using F10Y.T0003;


namespace F10Y.L0024
{
    /// <summary>
    /// 
    /// </summary>
    /// <inheritdoc cref="Documentation.SeeAlso_F10Y_L0060"/>
    [ValuesMarker]
    public partial interface IJsonSerializerOptionsSet
    {
        /// <summary>
        /// The default value provided by the parameterless constructor.
        /// </summary>
        public JsonSerializerOptions Default => new JsonSerializerOptions();

        /// <summary>
        /// <list type="bullet">
        /// <item><see cref="JsonSerializerOptions.WriteIndented"/>, true</item>
        /// </list>
        /// </summary>
        public JsonSerializerOptions Indented => new JsonSerializerOptions
        {
            WriteIndented = true
        };
    }
}
