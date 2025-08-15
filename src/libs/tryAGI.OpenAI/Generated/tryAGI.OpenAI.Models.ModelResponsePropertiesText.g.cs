
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelResponsePropertiesText
    {
        /// <summary>
        /// Constrains the verbosity of the model's response. Lower values will result in<br/>
        /// more concise responses, while higher values will result in more verbose responses.<br/>
        /// Currently supported values are `low`, `medium`, and `high`.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VerbosityJsonConverter))]
        public global::tryAGI.OpenAI.Verbosity? Verbosity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponsePropertiesText" /> class.
        /// </summary>
        /// <param name="verbosity">
        /// Constrains the verbosity of the model's response. Lower values will result in<br/>
        /// more concise responses, while higher values will result in more verbose responses.<br/>
        /// Currently supported values are `low`, `medium`, and `high`.<br/>
        /// Default Value: medium
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelResponsePropertiesText(
            global::tryAGI.OpenAI.Verbosity? verbosity)
        {
            this.Verbosity = verbosity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponsePropertiesText" /> class.
        /// </summary>
        public ModelResponsePropertiesText()
        {
        }
    }
}