
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the computer use tool. Always `computer_use_preview`.
    /// </summary>
    public enum ComputerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerToolType value)
        {
            return value switch
            {
                ComputerToolType.ComputerPreview => "computer-preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerToolType? ToEnum(string value)
        {
            return value switch
            {
                "computer-preview" => ComputerToolType.ComputerPreview,
                _ => null,
            };
        }
    }
}