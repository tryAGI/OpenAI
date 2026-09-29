
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// One user-entered value, including non-password fields such as an email address.
    /// </summary>
    public sealed partial class BrowserAuthenticationFieldValueParam
    {
        /// <summary>
        /// The field ID from the required action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldId { get; set; }

        /// <summary>
        /// The value to enter into the registered control.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserAuthenticationFieldValueParam" /> class.
        /// </summary>
        /// <param name="fieldId">
        /// The field ID from the required action.
        /// </param>
        /// <param name="value">
        /// The value to enter into the registered control.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserAuthenticationFieldValueParam(
            string fieldId,
            string value)
        {
            this.FieldId = fieldId ?? throw new global::System.ArgumentNullException(nameof(fieldId));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserAuthenticationFieldValueParam" /> class.
        /// </summary>
        public BrowserAuthenticationFieldValueParam()
        {
        }

    }
}