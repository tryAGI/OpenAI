
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutomationEnvironmentResourceNone
    {
        /// <summary>
        /// The type of the object. Always `none`.<br/>
        /// Default Value: none
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationEnvironmentResourceNoneType.None</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationEnvironmentResourceNoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceNoneType Type { get; set; } = global::tryAGI.OpenAI.AutomationEnvironmentResourceNoneType.None;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationEnvironmentResourceNone" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `none`.<br/>
        /// Default Value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationEnvironmentResourceNone(
            global::tryAGI.OpenAI.AutomationEnvironmentResourceNoneType type = global::tryAGI.OpenAI.AutomationEnvironmentResourceNoneType.None)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationEnvironmentResourceNone" /> class.
        /// </summary>
        public AutomationEnvironmentResourceNone()
        {
        }

    }
}