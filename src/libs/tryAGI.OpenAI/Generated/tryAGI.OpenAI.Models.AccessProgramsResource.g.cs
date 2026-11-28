
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessProgramsResource
    {
        /// <summary>
        /// The cyber access program explicitly selected for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CyberAccessProgramResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CyberAccessProgramResource Cyber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessProgramsResource" /> class.
        /// </summary>
        /// <param name="cyber">
        /// The cyber access program explicitly selected for this session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessProgramsResource(
            global::tryAGI.OpenAI.CyberAccessProgramResource cyber)
        {
            this.Cyber = cyber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessProgramsResource" /> class.
        /// </summary>
        public AccessProgramsResource()
        {
        }

    }
}