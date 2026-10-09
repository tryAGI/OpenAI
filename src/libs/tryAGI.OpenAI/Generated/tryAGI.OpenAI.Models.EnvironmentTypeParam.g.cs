
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The hosting type of an execution environment.
    /// </summary>
    public enum EnvironmentTypeParam
    {
        /// <summary>
        ///
        /// </summary>
        OpenaiHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentTypeParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentTypeParam value)
        {
            return value switch
            {
                EnvironmentTypeParam.OpenaiHosted => "openai_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentTypeParam? ToEnum(string value)
        {
            return value switch
            {
                "openai_hosted" => EnvironmentTypeParam.OpenaiHosted,
                _ => null,
            };
        }
    }
}