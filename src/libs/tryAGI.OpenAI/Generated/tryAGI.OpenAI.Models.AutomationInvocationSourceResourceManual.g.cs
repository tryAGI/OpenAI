
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutomationInvocationSourceResourceManual
    {
        /// <summary>
        /// The type of the object. Always `manual`.<br/>
        /// Default Value: manual
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationInvocationSourceResourceManualType.Manual</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationInvocationSourceResourceManualTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceManualType Type { get; set; } = global::tryAGI.OpenAI.AutomationInvocationSourceResourceManualType.Manual;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationInvocationSourceResourceManual" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `manual`.<br/>
        /// Default Value: manual
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationInvocationSourceResourceManual(
            global::tryAGI.OpenAI.AutomationInvocationSourceResourceManualType type = global::tryAGI.OpenAI.AutomationInvocationSourceResourceManualType.Manual)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationInvocationSourceResourceManual" /> class.
        /// </summary>
        public AutomationInvocationSourceResourceManual()
        {
        }

    }
}