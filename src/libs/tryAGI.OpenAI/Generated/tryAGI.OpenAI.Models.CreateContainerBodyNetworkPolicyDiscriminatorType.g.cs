
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateContainerBodyNetworkPolicyDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Allowlist,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateContainerBodyNetworkPolicyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContainerBodyNetworkPolicyDiscriminatorType value)
        {
            return value switch
            {
                CreateContainerBodyNetworkPolicyDiscriminatorType.Allowlist => "allowlist",
                CreateContainerBodyNetworkPolicyDiscriminatorType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContainerBodyNetworkPolicyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "allowlist" => CreateContainerBodyNetworkPolicyDiscriminatorType.Allowlist,
                "disabled" => CreateContainerBodyNetworkPolicyDiscriminatorType.Disabled,
                _ => null,
            };
        }
    }
}