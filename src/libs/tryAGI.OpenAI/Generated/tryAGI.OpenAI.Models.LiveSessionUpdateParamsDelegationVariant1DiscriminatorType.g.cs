
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveSessionUpdateParamsDelegationVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Client,
        /// <summary>
        ///
        /// </summary>
        Responses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionUpdateParamsDelegationVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionUpdateParamsDelegationVariant1DiscriminatorType value)
        {
            return value switch
            {
                LiveSessionUpdateParamsDelegationVariant1DiscriminatorType.Client => "client",
                LiveSessionUpdateParamsDelegationVariant1DiscriminatorType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionUpdateParamsDelegationVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => LiveSessionUpdateParamsDelegationVariant1DiscriminatorType.Client,
                "responses" => LiveSessionUpdateParamsDelegationVariant1DiscriminatorType.Responses,
                _ => null,
            };
        }
    }
}