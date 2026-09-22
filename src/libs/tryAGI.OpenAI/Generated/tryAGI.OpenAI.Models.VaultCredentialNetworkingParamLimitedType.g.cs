
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `limited`.<br/>
    /// Default Value: limited
    /// </summary>
    public enum VaultCredentialNetworkingParamLimitedType
    {
        /// <summary>
        ///
        /// </summary>
        Limited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultCredentialNetworkingParamLimitedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultCredentialNetworkingParamLimitedType value)
        {
            return value switch
            {
                VaultCredentialNetworkingParamLimitedType.Limited => "limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultCredentialNetworkingParamLimitedType? ToEnum(string value)
        {
            return value switch
            {
                "limited" => VaultCredentialNetworkingParamLimitedType.Limited,
                _ => null,
            };
        }
    }
}