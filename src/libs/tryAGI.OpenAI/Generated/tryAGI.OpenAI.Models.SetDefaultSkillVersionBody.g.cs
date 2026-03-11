
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Updates the default version pointer for a skill.
    /// </summary>
    public sealed partial class SetDefaultSkillVersionBody
    {
        /// <summary>
        /// The skill version number to set as default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string DefaultVersion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDefaultSkillVersionBody" /> class.
        /// </summary>
        /// <param name="defaultVersion">
        /// The skill version number to set as default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetDefaultSkillVersionBody(
            string defaultVersion)
        {
            this.DefaultVersion = defaultVersion ?? throw new global::System.ArgumentNullException(nameof(defaultVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDefaultSkillVersionBody" /> class.
        /// </summary>
        public SetDefaultSkillVersionBody()
        {
        }
    }
}