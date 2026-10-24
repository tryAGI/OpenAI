
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutomationCreatedByResourceDeveloper
    {
        /// <summary>
        /// The type of the object. Always `developer`.<br/>
        /// Default Value: developer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloperType.Developer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationCreatedByResourceDeveloperTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloperType Type { get; set; } = global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloperType.Developer;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationCreatedByResourceDeveloper" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `developer`.<br/>
        /// Default Value: developer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationCreatedByResourceDeveloper(
            global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloperType type = global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloperType.Developer)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationCreatedByResourceDeveloper" /> class.
        /// </summary>
        public AutomationCreatedByResourceDeveloper()
        {
        }

    }
}