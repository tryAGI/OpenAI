
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComputerUseApprovalResponseKindResourceDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceDiscriminatorActionJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseKindResourceDiscriminator" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUseApprovalResponseKindResourceDiscriminator(
            global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction? action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseKindResourceDiscriminator" /> class.
        /// </summary>
        public ComputerUseApprovalResponseKindResourceDiscriminator()
        {
        }

    }
}