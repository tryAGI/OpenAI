
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Credentials for SIP Digest authentication with your trunk provider.
    /// </summary>
    public sealed partial class LiveSIPTrunkAuth
    {
        /// <summary>
        /// Use `digest` for SIP Digest authentication. Handles 401 and 407 challenges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSIPTrunkAuthTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSIPTrunkAuthType Type { get; set; }

        /// <summary>
        /// Provider username. Must contain a non-whitespace character, be at most 256 bytes, and contain no CR, LF, or NUL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Provider password. Must be at most 4096 bytes and contain no CR, LF, or NUL.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSIPTrunkAuth" /> class.
        /// </summary>
        /// <param name="username">
        /// Provider username. Must contain a non-whitespace character, be at most 256 bytes, and contain no CR, LF, or NUL.
        /// </param>
        /// <param name="type">
        /// Use `digest` for SIP Digest authentication. Handles 401 and 407 challenges.
        /// </param>
        /// <param name="password">
        /// Provider password. Must be at most 4096 bytes and contain no CR, LF, or NUL.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSIPTrunkAuth(
            string username,
            global::tryAGI.OpenAI.LiveSIPTrunkAuthType type,
            string? password)
        {
            this.Type = type;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSIPTrunkAuth" /> class.
        /// </summary>
        public LiveSIPTrunkAuth()
        {
        }

    }
}