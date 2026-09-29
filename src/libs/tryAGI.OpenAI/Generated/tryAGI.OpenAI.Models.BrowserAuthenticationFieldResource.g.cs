
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A control in a registered browser-login form.
    /// </summary>
    public sealed partial class BrowserAuthenticationFieldResource
    {
        /// <summary>
        /// The field ID to submit as field_id in a fields entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The label to display beside the control.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The rendering type, such as email, password, or text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Whether this control requires a nonempty value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserAuthenticationFieldResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The field ID to submit as field_id in a fields entry.
        /// </param>
        /// <param name="label">
        /// The label to display beside the control.
        /// </param>
        /// <param name="type">
        /// The rendering type, such as email, password, or text.
        /// </param>
        /// <param name="required">
        /// Whether this control requires a nonempty value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserAuthenticationFieldResource(
            string id,
            string label,
            string type,
            bool required)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserAuthenticationFieldResource" /> class.
        /// </summary>
        public BrowserAuthenticationFieldResource()
        {
        }

    }
}