
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveSessionCreateParamsDelegationVariant1DiscriminatorType
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
    public static class LiveSessionCreateParamsDelegationVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionCreateParamsDelegationVariant1DiscriminatorType value)
        {
            return value switch
            {
                LiveSessionCreateParamsDelegationVariant1DiscriminatorType.Client => "client",
                LiveSessionCreateParamsDelegationVariant1DiscriminatorType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionCreateParamsDelegationVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => LiveSessionCreateParamsDelegationVariant1DiscriminatorType.Client,
                "responses" => LiveSessionCreateParamsDelegationVariant1DiscriminatorType.Responses,
                _ => null,
            };
        }
    }
}