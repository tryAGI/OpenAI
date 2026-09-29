
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A sign-in method and the fields that belong to it.
    /// </summary>
    public sealed partial class BrowserAuthenticationOptionResource
    {
        /// <summary>
        /// The option ID to submit as selected_option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The method label to display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// IDs from the registered fields that this method accepts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FieldIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserAuthenticationOptionResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The option ID to submit as selected_option.
        /// </param>
        /// <param name="label">
        /// The method label to display.
        /// </param>
        /// <param name="fieldIds">
        /// IDs from the registered fields that this method accepts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserAuthenticationOptionResource(
            string id,
            string label,
            global::System.Collections.Generic.IList<string> fieldIds)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.FieldIds = fieldIds ?? throw new global::System.ArgumentNullException(nameof(fieldIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserAuthenticationOptionResource" /> class.
        /// </summary>
        public BrowserAuthenticationOptionResource()
        {
        }

    }
}