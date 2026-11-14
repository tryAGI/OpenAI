
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReasoningInputTransformation
    {
        /// <summary>
        /// Default Value: reasoning
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ReasoningInputTransformationType.Reasoning</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningInputTransformationTypeJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningInputTransformationType Type { get; set; } = global::tryAGI.OpenAI.ReasoningInputTransformationType.Reasoning;

        /// <summary>
        /// The original reasoning item ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: removed
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ReasoningInputTransformationAction.Removed</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningInputTransformationActionJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningInputTransformationAction Action { get; set; } = global::tryAGI.OpenAI.ReasoningInputTransformationAction.Removed;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputRemovalReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.InputRemovalReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningInputTransformation" /> class.
        /// </summary>
        /// <param name="id">
        /// The original reasoning item ID.
        /// </param>
        /// <param name="reason"></param>
        /// <param name="type">
        /// Default Value: reasoning
        /// </param>
        /// <param name="action">
        /// Default Value: removed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningInputTransformation(
            string id,
            global::tryAGI.OpenAI.InputRemovalReason reason,
            global::tryAGI.OpenAI.ReasoningInputTransformationType type = global::tryAGI.OpenAI.ReasoningInputTransformationType.Reasoning,
            global::tryAGI.OpenAI.ReasoningInputTransformationAction action = global::tryAGI.OpenAI.ReasoningInputTransformationAction.Removed)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Action = action;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningInputTransformation" /> class.
        /// </summary>
        public ReasoningInputTransformation()
        {
        }

    }
}