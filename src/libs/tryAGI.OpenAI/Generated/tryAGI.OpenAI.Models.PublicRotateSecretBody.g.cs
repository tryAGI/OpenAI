
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicRotateSecretBody
    {
        /// <summary>
        /// Whether to keep the previous signing secret valid for 24 hours after rotation. Defaults to false, which invalidates the previous secret immediately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_old_secret_active_for_24_hours")]
        public bool? KeepOldSecretActiveFor24Hours { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicRotateSecretBody" /> class.
        /// </summary>
        /// <param name="keepOldSecretActiveFor24Hours">
        /// Whether to keep the previous signing secret valid for 24 hours after rotation. Defaults to false, which invalidates the previous secret immediately.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicRotateSecretBody(
            bool? keepOldSecretActiveFor24Hours)
        {
            this.KeepOldSecretActiveFor24Hours = keepOldSecretActiveFor24Hours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicRotateSecretBody" /> class.
        /// </summary>
        public PublicRotateSecretBody()
        {
        }

    }
}