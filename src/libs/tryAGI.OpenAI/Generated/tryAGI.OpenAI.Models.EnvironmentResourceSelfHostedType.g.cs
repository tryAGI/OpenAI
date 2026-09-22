
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `self_hosted`.<br/>
    /// Default Value: self_hosted
    /// </summary>
    public enum EnvironmentResourceSelfHostedType
    {
        /// <summary>
        ///
        /// </summary>
        SelfHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentResourceSelfHostedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentResourceSelfHostedType value)
        {
            return value switch
            {
                EnvironmentResourceSelfHostedType.SelfHosted => "self_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentResourceSelfHostedType? ToEnum(string value)
        {
            return value switch
            {
                "self_hosted" => EnvironmentResourceSelfHostedType.SelfHosted,
                _ => null,
            };
        }
    }
}