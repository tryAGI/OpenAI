
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Delegate tasks to a Responses model managed by the Live session.
    /// </summary>
    public sealed partial class LiveResponsesDelegationParam
    {
        /// <summary>
        /// The delegation owner. Always `responses` for tasks handled by the Responses API.<br/>
        /// Default Value: responses
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveResponsesDelegationParamType.Responses</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveResponsesDelegationParamType Type { get; set; } = global::tryAGI.OpenAI.LiveResponsesDelegationParamType.Responses;

        /// <summary>
        /// Backend model, prompt, and tools used when the Live session delegates a task to Responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParam Responses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponsesDelegationParam" /> class.
        /// </summary>
        /// <param name="responses">
        /// Backend model, prompt, and tools used when the Live session delegates a task to Responses.
        /// </param>
        /// <param name="type">
        /// The delegation owner. Always `responses` for tasks handled by the Responses API.<br/>
        /// Default Value: responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveResponsesDelegationParam(
            global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParam responses,
            global::tryAGI.OpenAI.LiveResponsesDelegationParamType type = global::tryAGI.OpenAI.LiveResponsesDelegationParamType.Responses)
        {
            this.Type = type;
            this.Responses = responses ?? throw new global::System.ArgumentNullException(nameof(responses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponsesDelegationParam" /> class.
        /// </summary>
        public LiveResponsesDelegationParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveResponsesDelegationParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveResponsesDelegationParam FromResponses(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParam responses)
        {
            return new LiveResponsesDelegationParam
            {
                Responses = responses,
            };
        }

    }
}