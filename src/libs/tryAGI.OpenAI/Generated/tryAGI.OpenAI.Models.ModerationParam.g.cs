
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for running moderation on the input and output of this response.
    /// </summary>
    public sealed partial class ModerationParam
    {
        /// <summary>
        /// The moderation model to use for moderated completions, e.g. 'omni-moderation-latest'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationParam" /> class.
        /// </summary>
        /// <param name="model">
        /// The moderation model to use for moderated completions, e.g. 'omni-moderation-latest'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationParam(
            string model)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationParam" /> class.
        /// </summary>
        public ModerationParam()
        {
        }

    }
}