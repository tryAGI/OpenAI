
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeOutputImageObject
    {
        /// <summary>
        /// Always `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter))]
        public global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `image`.
        /// </param>
        /// <param name="image"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDetailsToolCallsCodeOutputImageObject(
            global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage image,
            global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType type)
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