
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.create`.
    /// </summary>
    public enum RealtimeBetaClientEventResponseCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventResponseCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventResponseCreateType value)
        {
            return value switch
            {
                RealtimeBetaClientEventResponseCreateType.ResponseCreate => "response.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventResponseCreateType? ToEnum(string value)
        {
            return value switch
            {
                "response.create" => RealtimeBetaClientEventResponseCreateType.ResponseCreate,
                _ => null,
            };
        }
    }
}