
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveSpecificImageGenParam
    {
        /// <summary>
        /// The tool to call. Always `image_generation`.<br/>
        /// Default Value: image_generation
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSpecificImageGenParamType.ImageGeneration</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSpecificImageGenParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSpecificImageGenParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSpecificImageGenParamType.ImageGeneration;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificImageGenParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool to call. Always `image_generation`.<br/>
        /// Default Value: image_generation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSpecificImageGenParam(
            global::tryAGI.OpenAI.LiveSpecificImageGenParamType type = global::tryAGI.OpenAI.LiveSpecificImageGenParamType.ImageGeneration)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificImageGenParam" /> class.
        /// </summary>
        public LiveSpecificImageGenParam()
        {
        }

    }
}