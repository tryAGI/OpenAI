
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Uploads a skill either as a directory (multipart `files[]`) or as a single zip file.
    /// </summary>
    public sealed partial class CreateSkillBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillBody" /> class.
        /// </summary>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSkillBody(
            global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]> files)
        {
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillBody" /> class.
        /// </summary>
        public CreateSkillBody()
        {
        }
    }
}