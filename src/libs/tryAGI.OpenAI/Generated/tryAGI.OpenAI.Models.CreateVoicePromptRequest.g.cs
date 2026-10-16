
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Creates a synthetic voice from a text description. Supports application/json or multipart/form-data.
    /// </summary>
    public sealed partial class CreateVoicePromptRequest
    {
        /// <summary>
        /// Set to `prompt` to create a voice from a text description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateVoicePromptRequestTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateVoicePromptRequestType Type { get; set; }

        /// <summary>
        /// The name of the new voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the desired voice. Must not contain only whitespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional text for the voice to speak during creation. If omitted, a script is generated from the prompt. Must not be blank after trimming whitespace; scripts that are too short are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("script_hint")]
        public string? ScriptHint { get; set; }

        /// <summary>
        /// The voice creation model to use. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateVoicePromptRequestModel?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateVoicePromptRequestModel?>? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoicePromptRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the new voice.
        /// </param>
        /// <param name="prompt">
        /// A description of the desired voice. Must not contain only whitespace.
        /// </param>
        /// <param name="type">
        /// Set to `prompt` to create a voice from a text description.
        /// </param>
        /// <param name="scriptHint">
        /// Optional text for the voice to speak during creation. If omitted, a script is generated from the prompt. Must not be blank after trimming whitespace; scripts that are too short are rejected.
        /// </param>
        /// <param name="model">
        /// The voice creation model to use. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoicePromptRequest(
            string name,
            string prompt,
            global::tryAGI.OpenAI.CreateVoicePromptRequestType type,
            string? scriptHint,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateVoicePromptRequestModel?>? model)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ScriptHint = scriptHint;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoicePromptRequest" /> class.
        /// </summary>
        public CreateVoicePromptRequest()
        {
        }

    }
}