
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveNamespaceToolInputParam
    {
        /// <summary>
        /// Default Value: namespace
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveNamespaceToolInputParamType.Namespace</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveNamespaceToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveNamespaceToolInputParamType.Namespace;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveNamespaceToolInputParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: namespace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveNamespaceToolInputParam(
            global::tryAGI.OpenAI.LiveNamespaceToolInputParamType type = global::tryAGI.OpenAI.LiveNamespaceToolInputParamType.Namespace)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveNamespaceToolInputParam" /> class.
        /// </summary>
        public LiveNamespaceToolInputParam()
        {
        }

    }
}