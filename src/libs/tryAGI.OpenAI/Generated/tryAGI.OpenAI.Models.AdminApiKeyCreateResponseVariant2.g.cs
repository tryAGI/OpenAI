
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The newly created admin API key. The `value` field is only returned once, when the key is created.
    /// </summary>
    public sealed partial class AdminApiKeyCreateResponseVariant2
    {
        /// <summary>
        /// The value of the API key. Only shown on create.<br/>
        /// Example: sk-admin-1234abcd
        /// </summary>
        /// <example>sk-admin-1234abcd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeyCreateResponseVariant2" /> class.
        /// </summary>
        /// <param name="value">
        /// The value of the API key. Only shown on create.<br/>
        /// Example: sk-admin-1234abcd
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminApiKeyCreateResponseVariant2(
            string value)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeyCreateResponseVariant2" /> class.
        /// </summary>
        public AdminApiKeyCreateResponseVariant2()
        {
        }
    }
}