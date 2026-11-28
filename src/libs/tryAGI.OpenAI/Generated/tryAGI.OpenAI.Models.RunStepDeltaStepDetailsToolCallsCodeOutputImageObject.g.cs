
#nullable enable

namespace tryAGI.OpenAI
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
        /// <default>"image"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "image";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Image { get; set; }

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
        /// <param name="image"></param>
        /// <param name="type">
        /// Always `image`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDeltaStepDetailsToolCallsCodeOutputImageObject(
            int index,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? image,
            string type = "image")
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

        /// <summary>
        /// Creates a new <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputImageObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RunStepDeltaStepDetailsToolCallsCodeOutputImageObject FromIndex(int index)
        {
            return new RunStepDeltaStepDetailsToolCallsCodeOutputImageObject
            {
                Index = index,
            };
        }

    }
}