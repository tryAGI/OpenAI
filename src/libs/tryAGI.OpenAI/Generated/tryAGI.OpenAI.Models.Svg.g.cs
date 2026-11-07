
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Selects the model and reasoning effort used to author SVG output. Requires output_format=svg and access to SVG model selection. When model selection is enabled, supply svg.model. When model selection is disabled, omit this object. The top-level model selects the image model that creates the reference image. SVG generation requires n=1 and does not support streaming, partial images, prompt_rewriter, or output_compression.
    /// </summary>
    public sealed partial class Svg
    {
        /// <summary>
        /// Model used to author the SVG. Required when SVG model selection is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Reasoning settings for the SVG author, independent of image complexity. Omitted or null effort uses the author model's default. Supported efforts depend on the selected author model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.SvgReasoning? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Svg" /> class.
        /// </summary>
        /// <param name="model">
        /// Model used to author the SVG. Required when SVG model selection is enabled.
        /// </param>
        /// <param name="reasoning">
        /// Reasoning settings for the SVG author, independent of image complexity. Omitted or null effort uses the author model's default. Supported efforts depend on the selected author model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Svg(
            string model,
            global::tryAGI.OpenAI.SvgReasoning? reasoning)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Svg" /> class.
        /// </summary>
        public Svg()
        {
        }

    }
}