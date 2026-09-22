
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveResponsesDelegationSettingsInputParamToolDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveResponsesDelegationSettingsInputParamToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponsesDelegationSettingsInputParamToolDiscriminatorType value)
        {
            return value switch
            {
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Function => "function",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Function,
                "web_search" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}