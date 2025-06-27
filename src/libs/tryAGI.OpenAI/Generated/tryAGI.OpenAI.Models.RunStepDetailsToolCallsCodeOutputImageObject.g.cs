
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeOutputImageObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage Image { get; set; }

        /// <summary>
        /// Always `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="type">
        /// Always `image`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDetailsToolCallsCodeOutputImageObject(
            global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage image,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType type)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsCodeOutputImageObject()
        {
        }
    }
}