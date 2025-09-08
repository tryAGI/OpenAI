
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the tool, i.e. `function`.
    /// </summary>
    public enum RealtimeBetaResponseCreateParamsToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaResponseCreateParamsToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaResponseCreateParamsToolType value)
        {
            return value switch
            {
                RealtimeBetaResponseCreateParamsToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaResponseCreateParamsToolType? ToEnum(string value)
        {
            return value switch
            {
                "function" => RealtimeBetaResponseCreateParamsToolType.Function,
                _ => null,
            };
        }
    }
}