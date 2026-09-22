
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesClientEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseSteer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesClientEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesClientEventDiscriminatorType value)
        {
            return value switch
            {
                ResponsesClientEventDiscriminatorType.ResponseSteer => "response.steer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesClientEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "response.steer" => ResponsesClientEventDiscriminatorType.ResponseSteer,
                _ => null,
            };
        }
    }
}