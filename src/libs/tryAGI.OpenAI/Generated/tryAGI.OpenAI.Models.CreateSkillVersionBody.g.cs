
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Uploads a new immutable version of a skill.
    /// </summary>
    public sealed partial class CreateSkillVersionBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]> Files { get; set; }

        /// <summary>
        /// Whether to set this version as the default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillVersionBody" /> class.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="default">
        /// Whether to set this version as the default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSkillVersionBody(
            global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]> files,
            bool? @default)
        {
            this.Files = files;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillVersionBody" /> class.
        /// </summary>
        public CreateSkillVersionBody()
        {
        }
    }
}