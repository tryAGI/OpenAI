
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionInputJsonParam
    {
        /// <summary>
        /// Default Value: input_json
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionInputJsonParamType.InputJson</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionInputJsonParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionInputJsonParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionInputJsonParamType.InputJson;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveDecisionJsonObject, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionJsonObject>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDecisionJsonObject, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionJsonObject>> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionInputJsonParam" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// Default Value: input_json
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionInputJsonParam(
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDecisionJsonObject, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionJsonObject>> data,
            global::tryAGI.OpenAI.LiveDecisionInputJsonParamType type = global::tryAGI.OpenAI.LiveDecisionInputJsonParamType.InputJson)
        {
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionInputJsonParam" /> class.
        /// </summary>
        public LiveDecisionInputJsonParam()
        {
        }

    }
}