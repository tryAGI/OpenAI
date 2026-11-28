
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeOutputImageObject
    {
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage Image { get; set; }

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
            string type = "image")
        {
            this.Type = type;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsCodeOutputImageObject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RunStepDetailsToolCallsCodeOutputImageObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RunStepDetailsToolCallsCodeOutputImageObject FromImage(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage image)
        {
            return new RunStepDetailsToolCallsCodeOutputImageObject
            {
                Image = image,
            };
        }

    }
}