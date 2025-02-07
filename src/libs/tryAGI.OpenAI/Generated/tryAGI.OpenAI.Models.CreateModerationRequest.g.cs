
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModerationRequest
    {
        /// <summary>
        /// Input (or inputs) to classify. Can be a single string, an array of strings, or<br/>
        /// an array of multi-modal input objects similar to other models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputVariant3Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputVariant3Item>> Input { get; set; }

        /// <summary>
        /// The content moderation model you would like to use. Learn more in<br/>
        /// [the moderation guide](/docs/guides/moderation), and learn about<br/>
        /// available models [here](/docs/models#moderation).<br/>
        /// Default Value: omni-moderation-latest<br/>
        /// Example: omni-moderation-2024-09-26
        /// </summary>
        /// <example>omni-moderation-2024-09-26</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Input (or inputs) to classify. Can be a single string, an array of strings, or<br/>
        /// an array of multi-modal input objects similar to other models.
        /// </param>
        /// <param name="model">
        /// The content moderation model you would like to use. Learn more in<br/>
        /// [the moderation guide](/docs/guides/moderation), and learn about<br/>
        /// available models [here](/docs/models#moderation).<br/>
        /// Default Value: omni-moderation-latest<br/>
        /// Example: omni-moderation-2024-09-26
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModerationRequest(
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputVariant3Item>> input,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>? model)
        {
            this.Input = input;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequest" /> class.
        /// </summary>
        public CreateModerationRequest()
        {
        }
    }
}