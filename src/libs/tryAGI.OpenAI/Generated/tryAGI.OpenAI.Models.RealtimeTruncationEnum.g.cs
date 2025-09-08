
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The truncation strategy to use for the session. `auto` is the default truncation strategy. `disabled` will disable truncation and emit errors when the conversation exceeds the input token limit.
    /// </summary>
    public enum RealtimeTruncationEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTruncationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTruncationEnum value)
        {
            return value switch
            {
                RealtimeTruncationEnum.Auto => "auto",
                RealtimeTruncationEnum.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTruncationEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeTruncationEnum.Auto,
                "disabled" => RealtimeTruncationEnum.Disabled,
                _ => null,
            };
        }
    }
}