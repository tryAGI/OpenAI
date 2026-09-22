
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Update the Responses backend for an existing Live session without changing delegation ownership.
    /// </summary>
    public sealed partial class LiveResponsesDelegationUpdateParam
    {
        /// <summary>
        /// The delegation owner. Always `responses` for tasks handled by the Responses API.<br/>
        /// Default Value: responses
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType.Responses</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationUpdateParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType Type { get; set; } = global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType.Responses;

        /// <summary>
        /// Responses backend settings to update. Omitted settings keep their existing values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responses")]
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParam? Responses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponsesDelegationUpdateParam" /> class.
        /// </summary>
        /// <param name="responses">
        /// Responses backend settings to update. Omitted settings keep their existing values.
        /// </param>
        /// <param name="type">
        /// The delegation owner. Always `responses` for tasks handled by the Responses API.<br/>
        /// Default Value: responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveResponsesDelegationUpdateParam(
            global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParam? responses,
            global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType type = global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType.Responses)
        {
            this.Type = type;
            this.Responses = responses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponsesDelegationUpdateParam" /> class.
        /// </summary>
        public LiveResponsesDelegationUpdateParam()
        {
        }

    }
}