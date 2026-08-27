
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a computer screenshot, this property is always set to `computer_screenshot`.<br/>
    /// Default Value: computer_screenshot
    /// </summary>
    public enum BetaComputerScreenshotContentType
    {
        /// <summary>
        ///
        /// </summary>
        ComputerScreenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComputerScreenshotContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerScreenshotContentType value)
        {
            return value switch
            {
                BetaComputerScreenshotContentType.ComputerScreenshot => "computer_screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerScreenshotContentType? ToEnum(string value)
        {
            return value switch
            {
                "computer_screenshot" => BetaComputerScreenshotContentType.ComputerScreenshot,
                _ => null,
            };
        }
    }
}