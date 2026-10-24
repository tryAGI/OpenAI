
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAutomationParamsOnce
    {
        /// <summary>
        /// The type of the object. Always `once`.<br/>
        /// Default Value: once
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateAutomationParamsOnceType.Once</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateAutomationParamsOnceTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateAutomationParamsOnceType Type { get; set; } = global::tryAGI.OpenAI.CreateAutomationParamsOnceType.Once;

        /// <summary>
        /// A human-readable name for the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The session an automation invocation targets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationTargetParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AutomationTargetParam Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// A future Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset RunAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAutomationParamsOnce" /> class.
        /// </summary>
        /// <param name="name">
        /// A human-readable name for the automation.
        /// </param>
        /// <param name="target">
        /// The session an automation invocation targets.
        /// </param>
        /// <param name="runAt">
        /// A future Unix timestamp in seconds.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="type">
        /// The type of the object. Always `once`.<br/>
        /// Default Value: once
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAutomationParamsOnce(
            string name,
            global::tryAGI.OpenAI.AutomationTargetParam target,
            global::System.DateTimeOffset runAt,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::tryAGI.OpenAI.CreateAutomationParamsOnceType type = global::tryAGI.OpenAI.CreateAutomationParamsOnceType.Once)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Target = target;
            this.Metadata = metadata;
            this.RunAt = runAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAutomationParamsOnce" /> class.
        /// </summary>
        public CreateAutomationParamsOnce()
        {
        }

    }
}