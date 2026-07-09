
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a screenshot action, this property is always set to `screenshot`.<br/>
    /// Default Value: screenshot
    /// </summary>
    public enum BetaScreenshotParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Screenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaScreenshotParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaScreenshotParamType value)
        {
            return value switch
            {
                BetaScreenshotParamType.Screenshot => "screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaScreenshotParamType? ToEnum(string value)
        {
            return value switch
            {
                "screenshot" => BetaScreenshotParamType.Screenshot,
                _ => null,
            };
        }
    }
}