
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `text`.
    /// </summary>
    public enum ModerationTextInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationTextInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextInputType value)
        {
            return value switch
            {
                ModerationTextInputType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextInputType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ModerationTextInputType.Text,
                _ => null,
            };
        }
    }
}