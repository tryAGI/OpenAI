
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveFunctionToolChoiceParam
    {
        /// <summary>
        /// Default Value: function
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType.Function</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveFunctionToolChoiceParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType Type { get; set; } = global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType.Function;

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="LiveFunctionToolChoiceParam" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveFunctionToolChoiceParam(
            string name,
            global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType type = global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType.Function)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveFunctionToolChoiceParam" /> class.
        /// </summary>
        public LiveFunctionToolChoiceParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveFunctionToolChoiceParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveFunctionToolChoiceParam FromName(string name)
        {
            return new LiveFunctionToolChoiceParam
            {
                Name = name,
            };
        }

    }
}