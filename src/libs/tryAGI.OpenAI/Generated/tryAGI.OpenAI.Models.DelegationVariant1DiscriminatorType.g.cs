
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DelegationVariant1DiscriminatorType
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
    public static class DelegationVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DelegationVariant1DiscriminatorType value)
        {
            return value switch
            {
                DelegationVariant1DiscriminatorType.Client => "client",
                DelegationVariant1DiscriminatorType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DelegationVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => DelegationVariant1DiscriminatorType.Client,
                "responses" => DelegationVariant1DiscriminatorType.Responses,
                _ => null,
            };
        }
    }
}