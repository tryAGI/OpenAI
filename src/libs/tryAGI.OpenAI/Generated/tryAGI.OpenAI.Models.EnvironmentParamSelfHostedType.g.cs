
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `self_hosted`.<br/>
    /// Default Value: self_hosted
    /// </summary>
    public enum EnvironmentParamSelfHostedType
    {
        /// <summary>
        ///
        /// </summary>
        SelfHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentParamSelfHostedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentParamSelfHostedType value)
        {
            return value switch
            {
                EnvironmentParamSelfHostedType.SelfHosted => "self_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentParamSelfHostedType? ToEnum(string value)
        {
            return value switch
            {
                "self_hosted" => EnvironmentParamSelfHostedType.SelfHosted,
                _ => null,
            };
        }
    }
}