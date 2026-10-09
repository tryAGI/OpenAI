
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveSpecificCustomToolParam
    {
        /// <summary>
        /// The tool to call. Always `custom`.<br/>
        /// Default Value: custom
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSpecificCustomToolParamType.Custom</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSpecificCustomToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSpecificCustomToolParamType.Custom;

        /// <summary>
        /// The name of the custom tool to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificCustomToolParam" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the custom tool to call.
        /// </param>
        /// <param name="type">
        /// The tool to call. Always `custom`.<br/>
        /// Default Value: custom
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSpecificCustomToolParam(
            string name,
            global::tryAGI.OpenAI.LiveSpecificCustomToolParamType type = global::tryAGI.OpenAI.LiveSpecificCustomToolParamType.Custom)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificCustomToolParam" /> class.
        /// </summary>
        public LiveSpecificCustomToolParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveSpecificCustomToolParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveSpecificCustomToolParam FromName(string name)
        {
            return new LiveSpecificCustomToolParam
            {
                Name = name,
            };
        }

    }
}