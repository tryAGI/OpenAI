
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The history item type. Always `message`.<br/>
    /// Default Value: message
    /// </summary>
    public enum LiveInitialDeveloperMessageItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialDeveloperMessageItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialDeveloperMessageItemParamType value)
        {
            return value switch
            {
                LiveInitialDeveloperMessageItemParamType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialDeveloperMessageItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "message" => LiveInitialDeveloperMessageItemParamType.Message,
                _ => null,
            };
        }
    }
}