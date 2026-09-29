
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type. Always `computer_screenshot`.<br/>
    /// Default Value: computer_screenshot
    /// </summary>
    public enum ComputerScreenshotResourceType
    {
        /// <summary>
        ///
        /// </summary>
        ComputerScreenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerScreenshotResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerScreenshotResourceType value)
        {
            return value switch
            {
                ComputerScreenshotResourceType.ComputerScreenshot => "computer_screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerScreenshotResourceType? ToEnum(string value)
        {
            return value switch
            {
                "computer_screenshot" => ComputerScreenshotResourceType.ComputerScreenshot,
                _ => null,
            };
        }
    }
}