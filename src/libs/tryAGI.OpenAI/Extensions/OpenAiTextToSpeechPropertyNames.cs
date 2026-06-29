#nullable enable

namespace tryAGI.OpenAI;

/// <summary>
/// OpenAI-specific <see cref="Microsoft.Extensions.AI.TextToSpeechOptions.AdditionalProperties" /> keys.
/// </summary>
public static class OpenAiTextToSpeechPropertyNames
{
    /// <summary>Prompt-style voice instructions for models that support controllable speech, such as <c>gpt-4o-mini-tts</c>.</summary>
    public const string Instructions = "openai:instructions";

    /// <summary>When true, treats <see cref="Microsoft.Extensions.AI.TextToSpeechOptions.VoiceId" /> as a custom OpenAI voice ID object.</summary>
    public const string CustomVoice = "openai:custom_voice";
}
