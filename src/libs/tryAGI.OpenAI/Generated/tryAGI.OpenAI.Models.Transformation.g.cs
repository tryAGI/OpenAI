
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Transformation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Attribute { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transformation" /> class.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="expression"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Transformation(
            string attribute,
            string expression)
        {
            this.Attribute = attribute ?? throw new global::System.ArgumentNullException(nameof(attribute));
            this.Expression = expression ?? throw new global::System.ArgumentNullException(nameof(expression));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transformation" /> class.
        /// </summary>
        public Transformation()
        {
        }

    }
}