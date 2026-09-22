
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum VaultCredentialNetworkingParamDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Limited,
        /// <summary>
        ///
        /// </summary>
        Unrestricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultCredentialNetworkingParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultCredentialNetworkingParamDiscriminatorType value)
        {
            return value switch
            {
                VaultCredentialNetworkingParamDiscriminatorType.Limited => "limited",
                VaultCredentialNetworkingParamDiscriminatorType.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultCredentialNetworkingParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "limited" => VaultCredentialNetworkingParamDiscriminatorType.Limited,
                "unrestricted" => VaultCredentialNetworkingParamDiscriminatorType.Unrestricted,
                _ => null,
            };
        }
    }
}