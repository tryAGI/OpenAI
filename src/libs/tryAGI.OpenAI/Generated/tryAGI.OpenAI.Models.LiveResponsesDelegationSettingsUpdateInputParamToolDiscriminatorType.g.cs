
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType
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
    public static class LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType value)
        {
            return value switch
            {
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Function => "function",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Function,
                "web_search" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}