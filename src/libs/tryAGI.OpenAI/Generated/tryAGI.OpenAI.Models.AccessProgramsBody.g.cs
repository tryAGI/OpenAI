
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessProgramsBody
    {
        /// <summary>
        /// The effective Cyber access program used for this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CyberAccessProgramEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CyberAccessProgramEnum Cyber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessProgramsBody" /> class.
        /// </summary>
        /// <param name="cyber">
        /// The effective Cyber access program used for this response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessProgramsBody(
            global::tryAGI.OpenAI.CyberAccessProgramEnum cyber)
        {
            this.Cyber = cyber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessProgramsBody" /> class.
        /// </summary>
        public AccessProgramsBody()
        {
        }

    }
}