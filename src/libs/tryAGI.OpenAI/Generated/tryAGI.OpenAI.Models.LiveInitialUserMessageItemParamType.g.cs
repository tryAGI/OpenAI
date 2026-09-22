
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The history item type. Always `message`.<br/>
    /// Default Value: message
    /// </summary>
    public enum LiveInitialUserMessageItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialUserMessageItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialUserMessageItemParamType value)
        {
            return value switch
            {
                LiveInitialUserMessageItemParamType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialUserMessageItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "message" => LiveInitialUserMessageItemParamType.Message,
                _ => null,
            };
        }
    }
}