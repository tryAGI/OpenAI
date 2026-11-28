
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessProgramsParam2
    {
        /// <summary>
        /// Selects a cyber access program compatible with the model. Daybreak requires access to the selected tier. Omit to use the model default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CyberAccessProgramParamJsonConverter))]
        public global::tryAGI.OpenAI.CyberAccessProgramParam? Cyber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessProgramsParam2" /> class.
        /// </summary>
        /// <param name="cyber">
        /// Selects a cyber access program compatible with the model. Daybreak requires access to the selected tier. Omit to use the model default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessProgramsParam2(
            global::tryAGI.OpenAI.CyberAccessProgramParam? cyber)
        {
            this.Cyber = cyber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessProgramsParam2" /> class.
        /// </summary>
        public AccessProgramsParam2()
        {
        }

    }
}