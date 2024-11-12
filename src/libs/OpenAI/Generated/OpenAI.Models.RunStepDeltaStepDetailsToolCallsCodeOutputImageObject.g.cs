
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsCodeOutputImageObject
    {
        /// <summary>
        /// The index of the output in the outputs array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Always `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter))]
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the output in the outputs array.
        /// </param>
        /// <param name="type">
        /// Always `image`.
        /// </param>
        /// <param name="image"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDeltaStepDetailsToolCallsCodeOutputImageObject(
            int index,
            global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType type,
            global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? image)
        {
            this.Index = index;
            this.Type = type;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeOutputImageObject()
        {
        }
    }
}