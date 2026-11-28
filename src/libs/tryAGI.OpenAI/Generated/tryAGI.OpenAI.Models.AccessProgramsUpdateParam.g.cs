
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessProgramsUpdateParam
    {
        /// <summary>
        /// Cyber access program for subsequent turns. Omit to keep the current selection or send null to restore the model default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyber")]
        public global::tryAGI.OpenAI.CyberAccessProgramParam? Cyber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessProgramsUpdateParam" /> class.
        /// </summary>
        /// <param name="cyber">
        /// Cyber access program for subsequent turns. Omit to keep the current selection or send null to restore the model default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessProgramsUpdateParam(
            global::tryAGI.OpenAI.CyberAccessProgramParam? cyber)
        {
            this.Cyber = cyber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessProgramsUpdateParam" /> class.
        /// </summary>
        public AccessProgramsUpdateParam()
        {
        }

    }
}