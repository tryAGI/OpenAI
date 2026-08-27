
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponsesClientEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseInject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponsesClientEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponsesClientEventDiscriminatorType value)
        {
            return value switch
            {
                BetaResponsesClientEventDiscriminatorType.ResponseInject => "response.inject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponsesClientEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "response.inject" => BetaResponsesClientEventDiscriminatorType.ResponseInject,
                _ => null,
            };
        }
    }
}