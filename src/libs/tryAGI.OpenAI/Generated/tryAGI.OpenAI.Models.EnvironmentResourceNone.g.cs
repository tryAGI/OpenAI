
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The session talks to CCA without selecting or provisioning an execution environment.
    /// </summary>
    public sealed partial class EnvironmentResourceNone
    {
        /// <summary>
        /// The type of the object. Always `none`.<br/>
        /// Default Value: none
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EnvironmentResourceNoneType.None</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceNoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.EnvironmentResourceNoneType Type { get; set; } = global::tryAGI.OpenAI.EnvironmentResourceNoneType.None;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentResourceNone" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `none`.<br/>
        /// Default Value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentResourceNone(
            global::tryAGI.OpenAI.EnvironmentResourceNoneType type = global::tryAGI.OpenAI.EnvironmentResourceNoneType.None)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentResourceNone" /> class.
        /// </summary>
        public EnvironmentResourceNone()
        {
        }

    }
}