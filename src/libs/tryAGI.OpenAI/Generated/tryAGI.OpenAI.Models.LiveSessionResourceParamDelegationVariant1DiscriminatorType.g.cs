
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveSessionResourceParamDelegationVariant1DiscriminatorType
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
    public static class LiveSessionResourceParamDelegationVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionResourceParamDelegationVariant1DiscriminatorType value)
        {
            return value switch
            {
                LiveSessionResourceParamDelegationVariant1DiscriminatorType.Client => "client",
                LiveSessionResourceParamDelegationVariant1DiscriminatorType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionResourceParamDelegationVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => LiveSessionResourceParamDelegationVariant1DiscriminatorType.Client,
                "responses" => LiveSessionResourceParamDelegationVariant1DiscriminatorType.Responses,
                _ => null,
            };
        }
    }
}