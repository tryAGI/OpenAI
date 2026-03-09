
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents the use of a local environment to perform shell actions.
    /// </summary>
    public sealed partial class LocalEnvironmentResource
    {
        /// <summary>
        /// The environment type. Always `local`.<br/>
        /// Default Value: local
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LocalEnvironmentResourceType.Local</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.LocalEnvironmentResourceType Type { get; set; } = global::tryAGI.OpenAI.LocalEnvironmentResourceType.Local;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalEnvironmentResource" /> class.
        /// </summary>
        /// <param name="type">
        /// The environment type. Always `local`.<br/>
        /// Default Value: local
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalEnvironmentResource(
            global::tryAGI.OpenAI.LocalEnvironmentResourceType type = global::tryAGI.OpenAI.LocalEnvironmentResourceType.Local)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalEnvironmentResource" /> class.
        /// </summary>
        public LocalEnvironmentResource()
        {
        }
    }
}