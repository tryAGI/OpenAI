
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The kind of execution environment.
    /// </summary>
    public enum EnvironmentTypeResource
    {
        /// <summary>
        ///
        /// </summary>
        OpenaiHosted,
        /// <summary>
        ///
        /// </summary>
        SelfHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentTypeResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentTypeResource value)
        {
            return value switch
            {
                EnvironmentTypeResource.OpenaiHosted => "openai_hosted",
                EnvironmentTypeResource.SelfHosted => "self_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentTypeResource? ToEnum(string value)
        {
            return value switch
            {
                "openai_hosted" => EnvironmentTypeResource.OpenaiHosted,
                "self_hosted" => EnvironmentTypeResource.SelfHosted,
                _ => null,
            };
        }
    }
}