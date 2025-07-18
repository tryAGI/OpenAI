
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The `File` object represents a document that has been uploaded to OpenAI.
    /// </summary>
    public sealed partial class OpenAIFile
    {
        /// <summary>
        /// The size of the file, in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Bytes { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the file was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the file will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// The name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The file identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `file`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OpenAIFileObjectJsonConverter))]
        public global::tryAGI.OpenAI.OpenAIFileObject Object { get; set; }

        /// <summary>
        /// The intended purpose of the file. Supported values are `assistants`, `assistants_output`, `batch`, `batch_output`, `fine-tune`, `fine-tune-results`, `vision`, and `user_data`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OpenAIFilePurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OpenAIFilePurpose Purpose { get; set; }

        /// <summary>
        /// Deprecated. The current status of the file, which can be either `uploaded`, `processed`, or `error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OpenAIFileStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OpenAIFileStatus Status { get; set; }

        /// <summary>
        /// Deprecated. For details on why a fine-tuning training file failed validation, see the `error` field on `fine_tuning.job`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_details")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? StatusDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFile" /> class.
        /// </summary>
        /// <param name="bytes">
        /// The size of the file, in bytes.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the file was created.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when the file will expire.
        /// </param>
        /// <param name="filename">
        /// The name of the file.
        /// </param>
        /// <param name="id">
        /// The file identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `file`.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the file. Supported values are `assistants`, `assistants_output`, `batch`, `batch_output`, `fine-tune`, `fine-tune-results`, `vision`, and `user_data`.
        /// </param>
        /// <param name="status">
        /// Deprecated. The current status of the file, which can be either `uploaded`, `processed`, or `error`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIFile(
            int bytes,
            global::System.DateTimeOffset createdAt,
            string filename,
            string id,
            global::tryAGI.OpenAI.OpenAIFilePurpose purpose,
            global::tryAGI.OpenAI.OpenAIFileStatus status,
            global::System.DateTimeOffset? expiresAt,
            global::tryAGI.OpenAI.OpenAIFileObject @object)
        {
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Purpose = purpose;
            this.Status = status;
            this.ExpiresAt = expiresAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFile" /> class.
        /// </summary>
        public OpenAIFile()
        {
        }
    }
}