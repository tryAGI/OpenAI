
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `limited`.<br/>
    /// Default Value: limited
    /// </summary>
    public enum VaultCredentialNetworkingResourceLimitedType
    {
        /// <summary>
        ///
        /// </summary>
        Limited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultCredentialNetworkingResourceLimitedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultCredentialNetworkingResourceLimitedType value)
        {
            return value switch
            {
                VaultCredentialNetworkingResourceLimitedType.Limited => "limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultCredentialNetworkingResourceLimitedType? ToEnum(string value)
        {
            return value switch
            {
                "limited" => VaultCredentialNetworkingResourceLimitedType.Limited,
                _ => null,
            };
        }
    }
}