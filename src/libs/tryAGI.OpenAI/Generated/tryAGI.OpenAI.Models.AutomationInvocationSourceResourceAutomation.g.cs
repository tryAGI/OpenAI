
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutomationInvocationSourceResourceAutomation
    {
        /// <summary>
        /// The type of the object. Always `automation`.<br/>
        /// Default Value: automation
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomationType.Automation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationInvocationSourceResourceAutomationTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomationType Type { get; set; } = global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomationType.Automation;

        /// <summary>
        /// The automation snapshot for this occurrence, excluding confidential values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AutomationResource Automation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationInvocationSourceResourceAutomation" /> class.
        /// </summary>
        /// <param name="automation">
        /// The automation snapshot for this occurrence, excluding confidential values.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `automation`.<br/>
        /// Default Value: automation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationInvocationSourceResourceAutomation(
            global::tryAGI.OpenAI.AutomationResource automation,
            global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomationType type = global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomationType.Automation)
        {
            this.Type = type;
            this.Automation = automation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationInvocationSourceResourceAutomation" /> class.
        /// </summary>
        public AutomationInvocationSourceResourceAutomation()
        {
        }

    }
}