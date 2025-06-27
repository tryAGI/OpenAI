
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsCodeOutputImageObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Image { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="index">
        /// The index of the output in the outputs array.
        /// </param>
        /// <param name="type">
        /// Always `image`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDeltaStepDetailsToolCallsCodeOutputImageObject(
            int index,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? image,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType type)
        {
            this.Index = index;
            this.Image = image;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeOutputImageObject()
        {
        }
    }
}