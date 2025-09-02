
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the tool, i.e. `function`.
    /// </summary>
    public enum RealtimeSessionCreateRequestToolVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestToolVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestToolVariant1Type value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestToolVariant1Type.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestToolVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "function" => RealtimeSessionCreateRequestToolVariant1Type.Function,
                _ => null,
            };
        }
    }
}