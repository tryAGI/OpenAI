
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The wake policy type, always `speech`.<br/>
    /// Default Value: speech
    /// </summary>
    public enum LiveSpeechWakePolicyParamType
    {
        /// <summary>
        ///
        /// </summary>
        Speech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSpeechWakePolicyParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSpeechWakePolicyParamType value)
        {
            return value switch
            {
                LiveSpeechWakePolicyParamType.Speech => "speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSpeechWakePolicyParamType? ToEnum(string value)
        {
            return value switch
            {
                "speech" => LiveSpeechWakePolicyParamType.Speech,
                _ => null,
            };
        }
    }
}